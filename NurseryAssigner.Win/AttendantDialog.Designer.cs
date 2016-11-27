namespace NurseryAssigner.Win
{
  partial class AttendantDialog
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
      this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.genderLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ageGroupLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
      this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.genderLookUpEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ageGroupLookUpEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
      this.SuspendLayout();
      // 
      // deleteButton
      // 
      this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.deleteButton.Location = new System.Drawing.Point(78, 290);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(60, 23);
      this.deleteButton.TabIndex = 14;
      this.deleteButton.Text = "Delete";
      this.deleteButton.UseVisualStyleBackColor = true;
      this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
      // 
      // addButton
      // 
      this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.addButton.Location = new System.Drawing.Point(12, 290);
      this.addButton.Name = "addButton";
      this.addButton.Size = new System.Drawing.Size(60, 23);
      this.addButton.TabIndex = 13;
      this.addButton.Text = "Add";
      this.addButton.UseVisualStyleBackColor = true;
      this.addButton.Click += new System.EventHandler(this.addButton_Click);
      // 
      // okButton
      // 
      this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.okButton.Location = new System.Drawing.Point(690, 290);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(60, 23);
      this.okButton.TabIndex = 12;
      this.okButton.Text = "OK";
      this.okButton.UseVisualStyleBackColor = true;
      this.okButton.Click += new System.EventHandler(this.okButton_Click);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button1.Location = new System.Drawing.Point(756, 290);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(60, 23);
      this.button1.TabIndex = 11;
      this.button1.Text = "Cancel";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // gridControl
      // 
      this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridControl.Location = new System.Drawing.Point(2, 1);
      this.gridControl.MainView = this.gridView;
      this.gridControl.Name = "gridControl";
      this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ageGroupLookUpEdit,
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEdit1,
            this.genderLookUpEdit});
      this.gridControl.Size = new System.Drawing.Size(824, 283);
      this.gridControl.TabIndex = 15;
      this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
      // 
      // gridView
      // 
      this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn11,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
      this.gridView.GridControl = this.gridControl;
      this.gridView.Name = "gridView";
      this.gridView.OptionsView.ShowGroupPanel = false;
      // 
      // gridColumn1
      // 
      this.gridColumn1.Caption = "Last Name";
      this.gridColumn1.FieldName = "LastName";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.OptionsColumn.FixedWidth = true;
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn1.Width = 80;
      // 
      // gridColumn3
      // 
      this.gridColumn3.Caption = "First Name";
      this.gridColumn3.FieldName = "FirstName";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.OptionsColumn.FixedWidth = true;
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 1;
      this.gridColumn3.Width = 80;
      // 
      // gridColumn2
      // 
      this.gridColumn2.Caption = "Gender";
      this.gridColumn2.ColumnEdit = this.genderLookUpEdit;
      this.gridColumn2.FieldName = "Gender";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.OptionsColumn.FixedWidth = true;
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 2;
      this.gridColumn2.Width = 60;
      // 
      // genderLookUpEdit
      // 
      this.genderLookUpEdit.AutoHeight = false;
      this.genderLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.genderLookUpEdit.Name = "genderLookUpEdit";
      // 
      // gridColumn4
      // 
      this.gridColumn4.Caption = "Age Group";
      this.gridColumn4.ColumnEdit = this.ageGroupLookUpEdit;
      this.gridColumn4.FieldName = "AgeGroupID";
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.OptionsColumn.FixedWidth = true;
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 4;
      this.gridColumn4.Width = 82;
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
      // gridColumn11
      // 
      this.gridColumn11.Caption = "Grad Year";
      this.gridColumn11.FieldName = "GradYear";
      this.gridColumn11.Name = "gridColumn11";
      this.gridColumn11.OptionsColumn.FixedWidth = true;
      this.gridColumn11.Visible = true;
      this.gridColumn11.VisibleIndex = 3;
      this.gridColumn11.Width = 60;
      // 
      // gridColumn5
      // 
      this.gridColumn5.Caption = "Does AM";
      this.gridColumn5.ColumnEdit = this.repositoryItemCheckEdit1;
      this.gridColumn5.FieldName = "DoesAM";
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.OptionsColumn.FixedWidth = true;
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 5;
      this.gridColumn5.Width = 60;
      // 
      // repositoryItemCheckEdit1
      // 
      this.repositoryItemCheckEdit1.AutoHeight = false;
      this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
      // 
      // gridColumn6
      // 
      this.gridColumn6.Caption = "Does PM";
      this.gridColumn6.ColumnEdit = this.repositoryItemCheckEdit1;
      this.gridColumn6.FieldName = "DoesPM";
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.OptionsColumn.FixedWidth = true;
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 6;
      this.gridColumn6.Width = 60;
      // 
      // gridColumn7
      // 
      this.gridColumn7.Caption = "Exclusion Start";
      this.gridColumn7.ColumnEdit = this.repositoryItemDateEdit1;
      this.gridColumn7.FieldName = "ExclusionStart";
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.OptionsColumn.FixedWidth = true;
      this.gridColumn7.Visible = true;
      this.gridColumn7.VisibleIndex = 7;
      this.gridColumn7.Width = 92;
      // 
      // repositoryItemDateEdit1
      // 
      this.repositoryItemDateEdit1.AutoHeight = false;
      this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
      // 
      // gridColumn8
      // 
      this.gridColumn8.Caption = "Exclusion End";
      this.gridColumn8.ColumnEdit = this.repositoryItemDateEdit1;
      this.gridColumn8.FieldName = "ExclusionEnd";
      this.gridColumn8.Name = "gridColumn8";
      this.gridColumn8.OptionsColumn.FixedWidth = true;
      this.gridColumn8.Visible = true;
      this.gridColumn8.VisibleIndex = 8;
      this.gridColumn8.Width = 92;
      // 
      // gridColumn9
      // 
      this.gridColumn9.Caption = "Inactive";
      this.gridColumn9.ColumnEdit = this.repositoryItemCheckEdit1;
      this.gridColumn9.FieldName = "IsInactive";
      this.gridColumn9.Name = "gridColumn9";
      this.gridColumn9.OptionsColumn.FixedWidth = true;
      this.gridColumn9.Visible = true;
      this.gridColumn9.VisibleIndex = 9;
      this.gridColumn9.Width = 60;
      // 
      // gridColumn10
      // 
      this.gridColumn10.Caption = "Comment";
      this.gridColumn10.FieldName = "Comment";
      this.gridColumn10.Name = "gridColumn10";
      this.gridColumn10.Visible = true;
      this.gridColumn10.VisibleIndex = 10;
      this.gridColumn10.Width = 80;
      // 
      // AttendantDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(828, 317);
      this.Controls.Add(this.gridControl);
      this.Controls.Add(this.deleteButton);
      this.Controls.Add(this.addButton);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.button1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AttendantDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Attendants";
      this.Load += new System.EventHandler(this.AttendantDialog_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.genderLookUpEdit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ageGroupLookUpEdit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button deleteButton;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Button button1;
    private DevExpress.XtraGrid.GridControl gridControl;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ageGroupLookUpEdit;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit genderLookUpEdit;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
  }
}