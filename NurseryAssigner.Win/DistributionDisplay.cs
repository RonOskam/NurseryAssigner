using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NurseryAssigner.Data;

namespace NurseryAssigner.Win
{
  public partial class DistributionDisplay : UserControl
  {
    public DistributionDisplay()
    {
      InitializeComponent();
    }

    private DateTime _start;
    private DateTime _end;
    private Label _primaryLabel = null;
    private int? _primaryAttendant = null;
    private Label _secondaryLabel = null;
    private int? _secondaryAttendant = null;
    private bool _secondaryClicked = false;

    public event EventHandler AttendantSelected;
    
    public void DisplayCounts(DateTime start, DateTime end)
    {
      _start = start;
      _end = end;
      UpdateDisplay();
    }

    public int? PrimaryAttendant
    {
      get
      {
        return _primaryAttendant;
      }
    }

    public int? SecondaryAttendant
    {
      get
      {
        return _secondaryAttendant;
      }
    }

    public bool SecondaryClicked
    {
      get
      {
        return _secondaryClicked;
      }
    }

    public void UpdateDisplay()
    {
      var db = MainForm.DatabaseConnection();

      var font = new Font(distributionTable.Font, FontStyle.Bold);
      var row = 0;
      scrollPanel.SuspendLayout();
      distributionTable.SuspendLayout();
      var scrollPos = scrollPanel.HorizontalScroll.Value;

      distributionTable.Controls.Clear();

      var groups = db.AgeGroups.ToList();
      foreach (var group in groups)
      {
        addLabel(group.Name, 0, row, null, font);
        row++;
        foreach (var attendant in group.Attendants.Where(a => !a.IsInactive).OrderBy(a => a.LastName).ThenBy(a => a.FirstName).ToList())
        {
          var count = db.AttendantSchedules.Count(s => s.Service.Date >= _start && s.Service.Date <= _end && s.AttendantID == attendant.ID);
          var display = attendant.FullName;
          if (!attendant.DoesAM)
            display += " (P)";
          else if (!attendant.DoesPM)
            display += " (A)";
          addLabel(display, 0, row, attendant);
          addLabel(count.ToString(), 1, row);
          var newRowStyle = new RowStyle(SizeType.Absolute, 18);
          distributionTable.RowStyles.Add(newRowStyle);
          row++;

        }
      }
      scrollPanel.HorizontalScroll.Value = scrollPos;
      scrollPanel.ResumeLayout();
      distributionTable.ResumeLayout();
    }

    public void SelectAttendant(long attendantID, bool secondary)
    {
      foreach (var item in distributionTable.Controls)
      {
        if (item is Label)
        {
          var label = (Label)item;
          if (label.Tag != null && ((long)label.Tag) == attendantID)
          {
            highlightLabel(label, secondary);
            return;
          }
        }
      }
    }

    private void addLabel(string text, int column, int row, Attendant attendant = null, Font font = null)
    {
      var label = new Label();
      label.Text = text;
      label.Dock = DockStyle.Fill;
      label.Margin = new Padding(0);
      label.Padding = new Padding(0);
      label.TextAlign = ContentAlignment.MiddleLeft;

      if (font != null)
        label.Font = font;

      if (attendant != null)
      {
        label.MouseUp += Label_Click;
        label.Tag = attendant.ID;
      }
      distributionTable.Controls.Add(label, column, row);
    }

    private void Label_Click(object sender, MouseEventArgs e)
    {
      _secondaryClicked = (e.Button == MouseButtons.Right);
      highlightLabel((Label)sender, _secondaryClicked);

      AttendantSelected?.Invoke(sender, EventArgs.Empty);
    }

    private void highlightLabel(Label label, bool secondary)
    {
      if (!secondary)
      {
        _primaryAttendant = Convert.ToInt32(label.Tag);
        if (_primaryLabel != null)
          _primaryLabel.BackColor = Color.Transparent;
        label.BackColor = Color.Pink;
        _primaryLabel = label;
      }
      else
      {
        if (_secondaryAttendant.HasValue && _secondaryAttendant == Convert.ToInt32(label.Tag))
        {
          if (_secondaryLabel != null)
            _secondaryLabel.BackColor = Color.Transparent;
          _secondaryAttendant = null;
        }
        else
        {
          _secondaryAttendant = Convert.ToInt32(label.Tag);
          if (_secondaryLabel != null)
            _secondaryLabel.BackColor = Color.Transparent;
          label.BackColor = Color.LightBlue;
          _secondaryLabel = label;
        }
      }
    }

    private void scrollPanel_MouseEnter(object sender, EventArgs e)
    {
      scrollPanel.Focus();
    }

  }
}
