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

    public void DisplayCounts(DateTime start, DateTime end)
    {
      _start = start;
      _end = end;
      UpdateDisplay();
    }

    public void UpdateDisplay()
    {
      var db = new NurseryAssignerEntities();

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

        addLabel(group.Name, 0, row, font);
        row++;
        foreach (var person in counts.OrderBy(a => a.Key.FirstName).ThenBy(a => a.Key.LastName).ToList())
        {
          addLabel(person.Key.FullName, 0, row);
          addLabel(person.Count.ToString(), 1, row);
          var newRowStyle = new RowStyle(SizeType.Absolute, 18);
          distributionTable.RowStyles.Add(newRowStyle);
          row++;

        }
      }
      scrollPanel.HorizontalScroll.Value = scrollPos;
      scrollPanel.ResumeLayout();
      distributionTable.ResumeLayout();
    }

    private void addLabel(string text, int column, int row, Font font = null)
    {
      var label = new Label();
      label.Text = text;
      label.Dock = DockStyle.Fill;
      label.Margin = new Padding(0);
      label.Padding = new Padding(0);
      label.TextAlign = ContentAlignment.MiddleLeft;
      if (font != null)
        label.Font = font;
      distributionTable.Controls.Add(label, column, row);
    }

    private void scrollPanel_MouseEnter(object sender, EventArgs e)
    {
      scrollPanel.Focus();
    }

  }
}
