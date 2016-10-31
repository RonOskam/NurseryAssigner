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
      this.components = new System.ComponentModel.Container();
      this.loadButton = new System.Windows.Forms.Button();
      this.scrollPanel = new System.Windows.Forms.Panel();
      this.scheduleTable = new System.Windows.Forms.TableLayoutPanel();
      this.attendantMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.name1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.attendantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ageGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.assignmentCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.scrollPanel.SuspendLayout();
      this.attendantMenu.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // loadButton
      // 
      this.loadButton.Location = new System.Drawing.Point(12, 27);
      this.loadButton.Name = "loadButton";
      this.loadButton.Size = new System.Drawing.Size(54, 21);
      this.loadButton.TabIndex = 1;
      this.loadButton.Text = "Load";
      this.loadButton.UseVisualStyleBackColor = true;
      this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
      // 
      // scrollPanel
      // 
      this.scrollPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.scrollPanel.AutoScroll = true;
      this.scrollPanel.Controls.Add(this.scheduleTable);
      this.scrollPanel.Location = new System.Drawing.Point(0, 54);
      this.scrollPanel.Name = "scrollPanel";
      this.scrollPanel.Size = new System.Drawing.Size(712, 270);
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
            this.editToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(712, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
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
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendantsToolStripMenuItem,
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
      // 
      // ageGroupsToolStripMenuItem
      // 
      this.ageGroupsToolStripMenuItem.Name = "ageGroupsToolStripMenuItem";
      this.ageGroupsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
      this.ageGroupsToolStripMenuItem.Text = "Age Groups";
      // 
      // assignmentCountToolStripMenuItem
      // 
      this.assignmentCountToolStripMenuItem.Name = "assignmentCountToolStripMenuItem";
      this.assignmentCountToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
      this.assignmentCountToolStripMenuItem.Text = "Assignment Count";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(712, 324);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.scrollPanel);
      this.Controls.Add(this.loadButton);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "Nursury Assigner";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.scrollPanel.ResumeLayout(false);
      this.scrollPanel.PerformLayout();
      this.attendantMenu.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button loadButton;
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
  }
}

