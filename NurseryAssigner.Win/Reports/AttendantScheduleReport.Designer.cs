namespace NurseryAssigner.Win
{
  partial class AttendantScheduleReport
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendantScheduleReport));
      DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
      DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
      this.Detail = new DevExpress.XtraReports.UI.DetailBand();
      this.schedulePivotGrid = new DevExpress.XtraReports.UI.XRPivotGrid();
      this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource();
      this.fieldPosition1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
      this.fieldServiceDate = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
      this.xrPivotGridField1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
      this.pivotGridField1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
      this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
      this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
      this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
      this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
      this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
      this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
      this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
      this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
      this.fieldID1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
      this.fieldServiceID1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
      this.fieldAttendantID1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
      this.fieldAttendant1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
      ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // Detail
      // 
      this.Detail.Dpi = 100F;
      this.Detail.HeightF = 0F;
      this.Detail.Name = "Detail";
      this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.Detail.StyleName = "DataField";
      this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // schedulePivotGrid
      // 
      this.schedulePivotGrid.Appearance.Cell.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.schedulePivotGrid.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.schedulePivotGrid.Appearance.FieldHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.schedulePivotGrid.Appearance.FieldValue.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.schedulePivotGrid.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.schedulePivotGrid.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.schedulePivotGrid.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.schedulePivotGrid.Appearance.Lines.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.schedulePivotGrid.Appearance.TotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.schedulePivotGrid.DataSource = this.objectDataSource1;
      this.schedulePivotGrid.Dpi = 100F;
      this.schedulePivotGrid.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldPosition1,
            this.fieldServiceDate,
            this.xrPivotGridField1,
            this.pivotGridField1});
      this.schedulePivotGrid.LocationFloat = new DevExpress.Utils.PointFloat(0F, 57.37502F);
      this.schedulePivotGrid.Name = "schedulePivotGrid";
      this.schedulePivotGrid.OptionsPrint.FilterSeparatorBarPadding = 3;
      this.schedulePivotGrid.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
      this.schedulePivotGrid.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
      this.schedulePivotGrid.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
      this.schedulePivotGrid.OptionsView.ShowColumnGrandTotalHeader = false;
      this.schedulePivotGrid.OptionsView.ShowColumnGrandTotals = false;
      this.schedulePivotGrid.OptionsView.ShowColumnHeaders = false;
      this.schedulePivotGrid.OptionsView.ShowColumnTotals = false;
      this.schedulePivotGrid.OptionsView.ShowDataHeaders = false;
      this.schedulePivotGrid.OptionsView.ShowFilterHeaders = false;
      this.schedulePivotGrid.OptionsView.ShowRowHeaders = false;
      this.schedulePivotGrid.OptionsView.ShowRowTotals = false;
      this.schedulePivotGrid.SizeF = new System.Drawing.SizeF(751F, 46.95829F);
      // 
      // objectDataSource1
      // 
      this.objectDataSource1.DataSource = typeof(NurseryAssigner.Data.AttendantSchedule);
      this.objectDataSource1.Name = "objectDataSource1";
      // 
      // fieldPosition1
      // 
      this.fieldPosition1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
      this.fieldPosition1.AreaIndex = 0;
      this.fieldPosition1.FieldName = "Position";
      this.fieldPosition1.Name = "fieldPosition1";
      this.fieldPosition1.Options.ShowCustomTotals = false;
      this.fieldPosition1.Options.ShowGrandTotal = false;
      this.fieldPosition1.Options.ShowInExpressionEditor = false;
      this.fieldPosition1.Options.ShowTotals = false;
      this.fieldPosition1.Options.ShowValues = false;
      this.fieldPosition1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
      this.fieldPosition1.Width = 123;
      // 
      // fieldServiceDate
      // 
      this.fieldServiceDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.fieldServiceDate.AreaIndex = 0;
      this.fieldServiceDate.CellFormat.FormatString = "d";
      this.fieldServiceDate.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.fieldServiceDate.FieldName = "Service.Date";
      this.fieldServiceDate.Name = "fieldServiceDate";
      this.fieldServiceDate.Options.ShowGrandTotal = false;
      this.fieldServiceDate.Options.ShowTotals = false;
      this.fieldServiceDate.TotalCellFormat.FormatString = "d";
      this.fieldServiceDate.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.fieldServiceDate.ValueFormat.FormatString = "d";
      this.fieldServiceDate.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.fieldServiceDate.Width = 70;
      // 
      // xrPivotGridField1
      // 
      this.xrPivotGridField1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
      this.xrPivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.xrPivotGridField1.AreaIndex = 1;
      this.xrPivotGridField1.FieldName = "Service.AMPM";
      this.xrPivotGridField1.Name = "xrPivotGridField1";
      this.xrPivotGridField1.Options.ShowGrandTotal = false;
      this.xrPivotGridField1.Options.ShowTotals = false;
      this.xrPivotGridField1.Width = 35;
      // 
      // pivotGridField1
      // 
      this.pivotGridField1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
      this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
      this.pivotGridField1.AreaIndex = 0;
      this.pivotGridField1.FieldName = "Attendant.FullName";
      this.pivotGridField1.Name = "pivotGridField1";
      this.pivotGridField1.Options.ShowGrandTotal = false;
      this.pivotGridField1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
      this.pivotGridField1.Width = 150;
      // 
      // TopMargin
      // 
      this.TopMargin.Dpi = 100F;
      this.TopMargin.HeightF = 100F;
      this.TopMargin.Name = "TopMargin";
      this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // BottomMargin
      // 
      this.BottomMargin.Dpi = 100F;
      this.BottomMargin.HeightF = 100F;
      this.BottomMargin.Name = "BottomMargin";
      this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // reportHeaderBand1
      // 
      this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText1,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel7,
            this.schedulePivotGrid});
      this.reportHeaderBand1.Dpi = 100F;
      this.reportHeaderBand1.HeightF = 279.2499F;
      this.reportHeaderBand1.Name = "reportHeaderBand1";
      // 
      // xrRichText1
      // 
      this.xrRichText1.Dpi = 100F;
      this.xrRichText1.Font = new System.Drawing.Font("Arial", 9F);
      this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 117.7917F);
      this.xrRichText1.Name = "xrRichText1";
      this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
      this.xrRichText1.SizeF = new System.Drawing.SizeF(727.0833F, 155.2917F);
      this.xrRichText1.StylePriority.UseFont = false;
      // 
      // xrLabel4
      // 
      this.xrLabel4.Dpi = 100F;
      this.xrLabel4.Font = new System.Drawing.Font("Arial", 7F);
      this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 31.4167F);
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel4.SizeF = new System.Drawing.SizeF(727.0833F, 15.70834F);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.Text = "If you cannot serve when assigned you will need to find your own replacement by t" +
    "rading or finding a substitute.  Please arrive at least 20 minutes early!!";
      // 
      // xrLabel3
      // 
      this.xrLabel3.Dpi = 100F;
      this.xrLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
      this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(383.5833F, 0F);
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel3.SizeF = new System.Drawing.SizeF(20.83331F, 23F);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "to";
      this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
      // 
      // xrLabel2
      // 
      this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Service.Date")});
      this.xrLabel2.Dpi = 100F;
      this.xrLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
      this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(404.4167F, 0F);
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel2.SizeF = new System.Drawing.SizeF(127.0833F, 23F);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      xrSummary1.FormatString = "{0:MMMM yyyy}";
      xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Max;
      xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
      this.xrLabel2.Summary = xrSummary1;
      this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // xrLabel1
      // 
      this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Service.Date")});
      this.xrLabel1.Dpi = 100F;
      this.xrLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
      this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(256.5F, 0F);
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel1.SizeF = new System.Drawing.SizeF(127.0833F, 23F);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      xrSummary2.FormatString = "{0:MMMM}";
      xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Min;
      xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
      this.xrLabel1.Summary = xrSummary2;
      this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
      // 
      // xrLabel7
      // 
      this.xrLabel7.Dpi = 100F;
      this.xrLabel7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
      this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel7.SizeF = new System.Drawing.SizeF(242.9167F, 21.00002F);
      this.xrLabel7.StyleName = "Title";
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.StylePriority.UseForeColor = false;
      this.xrLabel7.Text = "Nursery Attendants Schedule";
      // 
      // Title
      // 
      this.Title.BackColor = System.Drawing.Color.Transparent;
      this.Title.BorderColor = System.Drawing.Color.Black;
      this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.Title.BorderWidth = 1F;
      this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      this.Title.ForeColor = System.Drawing.Color.Navy;
      this.Title.Name = "Title";
      // 
      // FieldCaption
      // 
      this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
      this.FieldCaption.BorderColor = System.Drawing.Color.Black;
      this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.FieldCaption.BorderWidth = 1F;
      this.FieldCaption.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      this.FieldCaption.ForeColor = System.Drawing.Color.Navy;
      this.FieldCaption.Name = "FieldCaption";
      // 
      // PageInfo
      // 
      this.PageInfo.BackColor = System.Drawing.Color.Transparent;
      this.PageInfo.BorderColor = System.Drawing.Color.Black;
      this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.PageInfo.BorderWidth = 1F;
      this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      this.PageInfo.ForeColor = System.Drawing.Color.Navy;
      this.PageInfo.Name = "PageInfo";
      // 
      // DataField
      // 
      this.DataField.BackColor = System.Drawing.Color.Transparent;
      this.DataField.BorderColor = System.Drawing.Color.Black;
      this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.DataField.BorderWidth = 1F;
      this.DataField.Font = new System.Drawing.Font("Arial", 8F);
      this.DataField.ForeColor = System.Drawing.Color.Black;
      this.DataField.Name = "DataField";
      this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      // 
      // fieldID1
      // 
      this.fieldID1.AreaIndex = 0;
      this.fieldID1.FieldName = "ID";
      this.fieldID1.Name = "fieldID1";
      // 
      // fieldServiceID1
      // 
      this.fieldServiceID1.AreaIndex = 1;
      this.fieldServiceID1.FieldName = "ServiceID";
      this.fieldServiceID1.Name = "fieldServiceID1";
      // 
      // fieldAttendantID1
      // 
      this.fieldAttendantID1.AreaIndex = 2;
      this.fieldAttendantID1.FieldName = "AttendantID";
      this.fieldAttendantID1.Name = "fieldAttendantID1";
      // 
      // fieldAttendant1
      // 
      this.fieldAttendant1.AreaIndex = 3;
      this.fieldAttendant1.FieldName = "Attendant";
      this.fieldAttendant1.Name = "fieldAttendant1";
      // 
      // AttendantScheduleReport
      // 
      this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportHeaderBand1});
      this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
      this.DataSource = this.objectDataSource1;
      this.Margins = new System.Drawing.Printing.Margins(49, 50, 100, 100);
      this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
      this.Version = "15.2";
      ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
    private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
    private DevExpress.XtraReports.UI.XRLabel xrLabel7;
    private DevExpress.XtraReports.UI.XRControlStyle Title;
    private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
    private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
    private DevExpress.XtraReports.UI.XRControlStyle DataField;
    private DevExpress.XtraReports.UI.XRPivotGrid schedulePivotGrid;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPosition1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldServiceDate;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldID1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldServiceID1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldAttendantID1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldAttendant1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField pivotGridField1;
    private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    private DevExpress.XtraReports.UI.XRRichText xrRichText1;
    private DevExpress.XtraReports.UI.XRLabel xrLabel4;
  }
}
