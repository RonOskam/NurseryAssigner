using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NurseryAssigner.Win
{
  public partial class AttendantScheduleReport : XtraReport
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
        e.Appearance.BackColor = Color.LightGray;
    }

    private void reportHeaderBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
      var db = MainForm.DatabaseConnection();
      var message = db.Parameters.Find(1).Value;
      footerMessageText.Text = message;
    }
  }
}
