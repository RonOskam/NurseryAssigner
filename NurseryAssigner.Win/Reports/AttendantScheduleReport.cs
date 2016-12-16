using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NurseryAssigner.Win
{
  public partial class AttendantScheduleReport : DevExpress.XtraReports.UI.XtraReport
  {
    public AttendantScheduleReport()
    {
      InitializeComponent();
    }
    
    private void schedulePivotGrid_PrintCell(object sender, DevExpress.XtraReports.UI.PivotGrid.CustomExportCellEventArgs e)
    {
      if (e.RowIndex % 2 == 0)
        e.Appearance.BackColor = Color.White;
      else
        e.Appearance.BackColor = Color.WhiteSmoke;
    }
  }
}
