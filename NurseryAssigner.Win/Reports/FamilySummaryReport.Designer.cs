namespace NurseryAssigner.Win.Reports
{
  partial class FamilySummaryReport
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
      this.Detail = new DevExpress.XtraReports.UI.DetailBand();
      this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
      this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
      this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
      this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
      this.groupHeaderBand2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
      this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
      this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
      this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
      this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
      this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
      this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource();
      this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
      this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
      ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // Detail
      // 
      this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel7});
      this.Detail.Dpi = 100F;
      this.Detail.Font = new System.Drawing.Font("Arial", 9F);
      this.Detail.HeightF = 20.91665F;
      this.Detail.Name = "Detail";
      this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Day", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("AMPM", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
      this.Detail.StyleName = "DataField";
      this.Detail.StylePriority.UseFont = false;
      this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // xrLabel8
      // 
      this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AMPM")});
      this.xrLabel8.Dpi = 100F;
      this.xrLabel8.Font = new System.Drawing.Font("Arial", 9F);
      this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(124.3773F, 0F);
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel8.SizeF = new System.Drawing.SizeF(89.09238F, 18F);
      this.xrLabel8.StylePriority.UseFont = false;
      this.xrLabel8.Text = "xrLabel8";
      // 
      // xrLabel7
      // 
      this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Day", "{0:M/d/yyyy}")});
      this.xrLabel7.Dpi = 100F;
      this.xrLabel7.Font = new System.Drawing.Font("Arial", 9F);
      this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(38.88175F, 0F);
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel7.SizeF = new System.Drawing.SizeF(85.4955F, 18F);
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.Text = "xrLabel7";
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
      // groupHeaderBand1
      // 
      this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
      this.groupHeaderBand1.Dpi = 100F;
      this.groupHeaderBand1.Font = new System.Drawing.Font("Arial", 9F);
      this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("GroupID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
      this.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage;
      this.groupHeaderBand1.HeightF = 23F;
      this.groupHeaderBand1.KeepTogether = true;
      this.groupHeaderBand1.Level = 1;
      this.groupHeaderBand1.Name = "groupHeaderBand1";
      this.groupHeaderBand1.StyleName = "DataField";
      this.groupHeaderBand1.StylePriority.UseFont = false;
      // 
      // groupHeaderBand2
      // 
      this.groupHeaderBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9});
      this.groupHeaderBand2.Dpi = 100F;
      this.groupHeaderBand2.Font = new System.Drawing.Font("Arial", 9F);
      this.groupHeaderBand2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Name", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
      this.groupHeaderBand2.HeightF = 20.08333F;
      this.groupHeaderBand2.Name = "groupHeaderBand2";
      this.groupHeaderBand2.StyleName = "DataField";
      this.groupHeaderBand2.StylePriority.UseFont = false;
      // 
      // xrLabel9
      // 
      this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Name")});
      this.xrLabel9.Dpi = 100F;
      this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(21.80293F, 0F);
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel9.SizeF = new System.Drawing.SizeF(163.8108F, 18F);
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
      // xrLabel1
      // 
      this.xrLabel1.Dpi = 100F;
      this.xrLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
      this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel1.SizeF = new System.Drawing.SizeF(515.6971F, 23F);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "Here are the nursery schedule dates for your family";
      // 
      // objectDataSource1
      // 
      this.objectDataSource1.DataSource = typeof(NurseryAssigner.Data.AttendantSummary);
      this.objectDataSource1.Name = "objectDataSource1";
      // 
      // GroupFooter1
      // 
      this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
      this.GroupFooter1.Dpi = 100F;
      this.GroupFooter1.HeightF = 27.08333F;
      this.GroupFooter1.Level = 1;
      this.GroupFooter1.Name = "GroupFooter1";
      // 
      // xrPanel1
      // 
      this.xrPanel1.Dpi = 100F;
      this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(179.1667F, 2.083333F);
      this.xrPanel1.Name = "xrPanel1";
      this.xrPanel1.SizeF = new System.Drawing.SizeF(300F, 25F);
      // 
      // FamilySummaryReport
      // 
      this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.groupHeaderBand1,
            this.groupHeaderBand2,
            this.GroupFooter1});
      this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
      this.DataSource = this.objectDataSource1;
      this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
      this.Version = "15.2";
      ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.XRLabel xrLabel8;
    private DevExpress.XtraReports.UI.XRLabel xrLabel9;
    private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
    private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand1;
    private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand2;
    private DevExpress.XtraReports.UI.XRLabel xrLabel7;
    private DevExpress.XtraReports.UI.XRControlStyle Title;
    private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
    private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
    private DevExpress.XtraReports.UI.XRControlStyle DataField;
    private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
    private DevExpress.XtraReports.UI.XRPanel xrPanel1;
  }
}
