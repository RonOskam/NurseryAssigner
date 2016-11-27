namespace NurseryAssigner.Win
{
  partial class MainForm
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
      this.scrollPanel = new System.Windows.Forms.Panel();
      this.scheduleTable = new System.Windows.Forms.TableLayoutPanel();
      this.attendantMenu = new System.Windows.Forms.ContextMenuStrip();
      this.name1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buildScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.attendantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.additonalDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ageGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.assignmentCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.startDateLabel = new System.Windows.Forms.Label();
      this.endDateLabel = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.distributionDisplay = new NurseryAssigner.Win.DistributionDisplay();
      this.scrollPanel.SuspendLayout();
      this.attendantMenu.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // scrollPanel
      // 
      this.scrollPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.scrollPanel.AutoScroll = true;
      this.scrollPanel.Controls.Add(this.scheduleTable);
      this.scrollPanel.Location = new System.Drawing.Point(0, 47);
      this.scrollPanel.Name = "scrollPanel";
      this.scrollPanel.Size = new System.Drawing.Size(656, 277);
      this.scrollPanel.TabIndex = 2;
      // 
      // scheduleTable
      // 
      this.scheduleTable.AllowDrop = true;
      this.scheduleTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.scheduleTable.AutoSize = true;
      this.scheduleTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.scheduleTable.ColumnCount = 2;
      this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.scheduleTable.Location = new System.Drawing.Point(0, 0);
      this.scheduleTable.Name = "scheduleTable";
      this.scheduleTable.RowCount = 1;
      this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
      this.scheduleTable.Size = new System.Drawing.Size(90, 18);
      this.scheduleTable.TabIndex = 1;
      // 
      // attendantMenu
      // 
      this.attendantMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.name1ToolStripMenuItem});
      this.attendantMenu.Name = "attendantMenu";
      this.attendantMenu.Size = new System.Drawing.Size(116, 26);
      // 
      // name1ToolStripMenuItem
      // 
      this.name1ToolStripMenuItem.Name = "name1ToolStripMenuItem";
      this.name1ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
      this.name1ToolStripMenuItem.Text = "Name 1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dateRangeToolStripMenuItem,
            this.editToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(842, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // dateRangeToolStripMenuItem
      // 
      this.dateRangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.buildScheduleToolStripMenuItem});
      this.dateRangeToolStripMenuItem.Name = "dateRangeToolStripMenuItem";
      this.dateRangeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
      this.dateRangeToolStripMenuItem.Text = "Date Range";
      // 
      // selectToolStripMenuItem
      // 
      this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
      this.selectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.selectToolStripMenuItem.Text = "Select";
      this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
      // 
      // buildScheduleToolStripMenuItem
      // 
      this.buildScheduleToolStripMenuItem.Name = "buildScheduleToolStripMenuItem";
      this.buildScheduleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.buildScheduleToolStripMenuItem.Text = "Build Schedule";
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendantsToolStripMenuItem,
            this.additonalDayToolStripMenuItem,
            this.ageGroupsToolStripMenuItem,
            this.assignmentCountToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "Edit";
      // 
      // attendantsToolStripMenuItem
      // 
      this.attendantsToolStripMenuItem.Name = "attendantsToolStripMenuItem";
      this.attendantsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
      this.attendantsToolStripMenuItem.Text = "Attendants";
      this.attendantsToolStripMenuItem.Click += new System.EventHandler(this.attendantsToolStripMenuItem_Click);
      // 
      // additonalDayToolStripMenuItem
      // 
      this.additonalDayToolStripMenuItem.Name = "additonalDayToolStripMenuItem";
      this.additonalDayToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
      this.additonalDayToolStripMenuItem.Text = "Additonal Services";
      this.additonalDayToolStripMenuItem.Click += new System.EventHandler(this.additonalDayToolStripMenuItem_Click);
      // 
      // ageGroupsToolStripMenuItem
      // 
      this.ageGroupsToolStripMenuItem.Name = "ageGroupsToolStripMenuItem";
      this.ageGroupsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
      this.ageGroupsToolStripMenuItem.Text = "Age Groups";
      this.ageGroupsToolStripMenuItem.Click += new System.EventHandler(this.ageGroupsToolStripMenuItem_Click);
      // 
      // assignmentCountToolStripMenuItem
      // 
      this.assignmentCountToolStripMenuItem.Name = "assignmentCountToolStripMenuItem";
      this.assignmentCountToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
      this.assignmentCountToolStripMenuItem.Text = "Assignment Count";
      this.assignmentCountToolStripMenuItem.Click += new System.EventHandler(this.assignmentCountToolStripMenuItem_Click);
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.newToolStripMenuItem.Text = "New";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.openToolStripMenuItem.Text = "Open";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Dates:";
      // 
      // startDateLabel
      // 
      this.startDateLabel.AutoSize = true;
      this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startDateLabel.Location = new System.Drawing.Point(51, 26);
      this.startDateLabel.Name = "startDateLabel";
      this.startDateLabel.Size = new System.Drawing.Size(0, 13);
      this.startDateLabel.TabIndex = 6;
      // 
      // endDateLabel
      // 
      this.endDateLabel.AutoSize = true;
      this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.endDateLabel.Location = new System.Drawing.Point(141, 26);
      this.endDateLabel.Name = "endDateLabel";
      this.endDateLabel.Size = new System.Drawing.Size(0, 13);
      this.endDateLabel.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(119, 26);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(16, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "to";
      // 
      // distributionDisplay
      // 
      this.distributionDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.distributionDisplay.Location = new System.Drawing.Point(675, 47);
      this.distributionDisplay.Name = "distributionDisplay";
      this.distributionDisplay.Size = new System.Drawing.Size(166, 276);
      this.distributionDisplay.TabIndex = 9;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(842, 324);
      this.Controls.Add(this.distributionDisplay);
      this.Controls.Add(this.endDateLabel);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.startDateLabel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.scrollPanel);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "Nursury Assigner";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.Shown += new System.EventHandler(this.MainForm_Shown);
      this.scrollPanel.ResumeLayout(false);
      this.scrollPanel.PerformLayout();
      this.attendantMenu.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel scrollPanel;
    private System.Windows.Forms.TableLayoutPanel scheduleTable;
    private System.Windows.Forms.ContextMenuStrip attendantMenu;
    private System.Windows.Forms.ToolStripMenuItem name1ToolStripMenuItem;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem attendantsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ageGroupsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem assignmentCountToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem additonalDayToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label startDateLabel;
    private System.Windows.Forms.Label endDateLabel;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ToolStripMenuItem dateRangeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem buildScheduleToolStripMenuItem;
    private DistributionDisplay distributionDisplay;
  }
}

