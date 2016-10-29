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
      this.loadButton = new System.Windows.Forms.Button();
      this.scrollPanel = new System.Windows.Forms.Panel();
      this.scheduleTable = new System.Windows.Forms.TableLayoutPanel();
      this.scrollPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // loadButton
      // 
      this.loadButton.Location = new System.Drawing.Point(12, 10);
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
      this.scrollPanel.Location = new System.Drawing.Point(0, 37);
      this.scrollPanel.Name = "scrollPanel";
      this.scrollPanel.Size = new System.Drawing.Size(712, 287);
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(712, 324);
      this.Controls.Add(this.scrollPanel);
      this.Controls.Add(this.loadButton);
      this.Name = "MainForm";
      this.Text = "Nursury Assigner";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.scrollPanel.ResumeLayout(false);
      this.scrollPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button loadButton;
    private System.Windows.Forms.Panel scrollPanel;
    private System.Windows.Forms.TableLayoutPanel scheduleTable;
  }
}

