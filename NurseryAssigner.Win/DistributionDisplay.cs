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
    private Label _selectedLabel = null;
    private int? _selectedAttendant = null;

    public event EventHandler AttendantSelected;
    
    public void DisplayCounts(DateTime start, DateTime end)
    {
      _start = start;
      _end = end;
      UpdateDisplay();
    }

    public int? SelectedAttendant
    {
      get
      {
        return _selectedAttendant;
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
        var counts = db.AttendantSchedules.Where(s => s.Service.Date >= _start && s.Service.Date <= _end && s.Attendant.AgeGroupID == group.ID)
          .GroupBy(s => s.Attendant)
          .Select(s => new { s.Key, Count = s.Count() }).ToList();

        addLabel(group.Name, 0, row, null, font);
        row++;
        foreach (var attendant in counts.OrderBy(a => a.Key.FirstName).ThenBy(a => a.Key.LastName).ToList())
        {
          var display = attendant.Key.FullName;
          if (!attendant.Key.DoesAM)
            display += " (P)";
          else if (!attendant.Key.DoesPM)
            display += " (A)";
          addLabel(display, 0, row, attendant.Key);
          addLabel(attendant.Count.ToString(), 1, row);
          var newRowStyle = new RowStyle(SizeType.Absolute, 18);
          distributionTable.RowStyles.Add(newRowStyle);
          row++;

        }
      }
      scrollPanel.HorizontalScroll.Value = scrollPos;
      scrollPanel.ResumeLayout();
      distributionTable.ResumeLayout();
    }

    public void SelectAttendant(long attendantID)
    {
      foreach (var item in distributionTable.Controls)
      {
        if (item is Label)
        {
          var label = (Label)item;
          if (label.Tag != null && ((long)label.Tag) == attendantID)
          {
            highlightLabel(label);
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
        label.Click += Label_Click;
        label.Tag = attendant.ID;
      }
      distributionTable.Controls.Add(label, column, row);
    }

    private void Label_Click(object sender, EventArgs e)
    {
      highlightLabel((Label)sender);

      AttendantSelected?.Invoke(sender, EventArgs.Empty);
    }

    private void highlightLabel(Label label)
    {
      _selectedAttendant = Convert.ToInt32(label.Tag);
      if (_selectedLabel != null)
        _selectedLabel.BackColor = Color.Transparent;
      label.BackColor = Color.LightGreen;
      _selectedLabel = label;
    }

    private void scrollPanel_MouseEnter(object sender, EventArgs e)
    {
      scrollPanel.Focus();
    }

  }
}
