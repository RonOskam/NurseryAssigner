namespace NurseryAssigner.Win
{
  partial class AssignmentCountDialog
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.deleteButton = new System.Windows.Forms.Button();
      this.addButton = new System.Windows.Forms.Button();
      this.okButton = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.gridControl = new DevExpress.XtraGrid.GridControl();
      this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ampmLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ageGroupLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ampmLookUpEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ageGroupLookUpEdit)).BeginInit();
      this.SuspendLayout();
      // 
      // deleteButton
      // 
      this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.deleteButton.Location = new System.Drawing.Point(78, 232);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(60, 23);
      this.deleteButton.TabIndex = 9;
      this.deleteButton.Text = "Delete";
      this.deleteButton.UseVisualStyleBackColor = true;
      this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
      // 
      // addButton
      // 
      this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.addButton.Location = new System.Drawing.Point(12, 232);
      this.addButton.Name = "addButton";
      this.addButton.Size = new System.Drawing.Size(60, 23);
      this.addButton.TabIndex = 8;
      this.addButton.Text = "Add";
      this.addButton.UseVisualStyleBackColor = true;
      this.addButton.Click += new System.EventHandler(this.addButton_Click);
      // 
      // okButton
      // 
      this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.okButton.Location = new System.Drawing.Point(234, 232);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(60, 23);
      this.okButton.TabIndex = 7;
      this.okButton.Text = "OK";
      this.okButton.UseVisualStyleBackColor = true;
      this.okButton.Click += new System.EventHandler(this.okButton_Click);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button1.Location = new System.Drawing.Point(300, 232);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(60, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "Cancel";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // gridControl
      // 
      this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridControl.Location = new System.Drawing.Point(3, 2);
      this.gridControl.MainView = this.gridView;
      this.gridControl.Name = "gridControl";
      this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ampmLookUpEdit,
            this.ageGroupLookUpEdit});
      this.gridControl.Size = new System.Drawing.Size(366, 224);
      this.gridControl.TabIndex = 10;
      this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
      // 
      // gridView
      // 
      this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
      this.gridView.GridControl = this.gridControl;
      this.gridView.Name = "gridView";
      this.gridView.OptionsView.ShowGroupPanel = false;
      // 
      // gridColumn1
      // 
      this.gridColumn1.Caption = "AM/PM";
      this.gridColumn1.ColumnEdit = this.ampmLookUpEdit;
      this.gridColumn1.FieldName = "AMPM";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      // 
      // ampmLookUpEdit
      // 
      this.ampmLookUpEdit.AutoHeight = false;
      this.ampmLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.ampmLookUpEdit.Name = "ampmLookUpEdit";
      this.ampmLookUpEdit.NullText = "";
      this.ampmLookUpEdit.ShowFooter = false;
      this.ampmLookUpEdit.ShowHeader = false;
      this.ampmLookUpEdit.ShowLines = false;
      // 
      // gridColumn2
      // 
      this.gridColumn2.Caption = "Age Group";
      this.gridColumn2.ColumnEdit = this.ageGroupLookUpEdit;
      this.gridColumn2.FieldName = "AgeGroupID";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 1;
      // 
      // ageGroupLookUpEdit
      // 
      this.ageGroupLookUpEdit.AutoHeight = false;
      this.ageGroupLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.ageGroupLookUpEdit.Name = "ageGroupLookUpEdit";
      this.ageGroupLookUpEdit.NullText = "";
      this.ageGroupLookUpEdit.ShowFooter = false;
      this.ageGroupLookUpEdit.ShowHeader = false;
      this.ageGroupLookUpEdit.ShowLines = false;
      // 
      // gridColumn3
      // 
      this.gridColumn3.Caption = "Amount";
      this.gridColumn3.FieldName = "Amount";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 2;
      // 
      // AssignmentCountDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(372, 261);
      this.Controls.Add(this.gridControl);
      this.Controls.Add(this.deleteButton);
      this.Controls.Add(this.addButton);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.button1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AssignmentCountDialog";
      this.Text = "Assignment Count";
      this.Load += new System.EventHandler(this.AssignmentCountDialog_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ampmLookUpEdit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ageGroupLookUpEdit)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button deleteButton;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Button button1;
    private DevExpress.XtraGrid.GridControl gridControl;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ampmLookUpEdit;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ageGroupLookUpEdit;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
  }
}