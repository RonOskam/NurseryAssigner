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

    public void UpdateDisplay(DateTime start, DateTime end)
    {
      var db = new NurseryAssignerEntities();

      var font = new Font(distributionTable.Font, FontStyle.Bold);
      var row = 0;

      var groups = db.AgeGroups.ToList();
      foreach (var group in groups)
      {
        var counts = db.AttendantSchedules.Where(s => s.Service.Date >= start && s.Service.Date <= end && s.Attendant.AgeGroupID == group.ID)
          .OrderBy(s => s.Attendant.FirstName).ThenBy(s =>s.Attendant.LastName)
          .GroupBy(s => s.Attendant)
          .Select(s => new { s.Key, Count = s.Count() }).ToList();

        addLabel(group.Name, 0, row, font);
        row++;
        foreach(var person in counts)
        {
          addLabel(person.Key.FullName, 0, row);
          addLabel(person.Count.ToString(), 1, row);
          var newRowStyle = new RowStyle(SizeType.Absolute, 20);
          distributionTable.RowStyles.Add(newRowStyle);
          row++;

        }
      }
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

  }
}
