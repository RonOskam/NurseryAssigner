namespace NurseryAssigner.Win
{
  partial class DistributionDisplay
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.scrollPanel = new System.Windows.Forms.Panel();
      this.distributionTable = new System.Windows.Forms.TableLayoutPanel();
      this.scrollPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // scrollPanel
      // 
      this.scrollPanel.AutoScroll = true;
      this.scrollPanel.Controls.Add(this.distributionTable);
      this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.scrollPanel.Location = new System.Drawing.Point(0, 0);
      this.scrollPanel.Name = "scrollPanel";
      this.scrollPanel.Size = new System.Drawing.Size(219, 150);
      this.scrollPanel.TabIndex = 3;
      this.scrollPanel.MouseEnter += new System.EventHandler(this.scrollPanel_MouseEnter);
      // 
      // distributionTable
      // 
      this.distributionTable.AllowDrop = true;
      this.distributionTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.distributionTable.AutoSize = true;
      this.distributionTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.distributionTable.ColumnCount = 2;
      this.distributionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
      this.distributionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.distributionTable.Location = new System.Drawing.Point(0, 0);
      this.distributionTable.Margin = new System.Windows.Forms.Padding(1);
      this.distributionTable.Name = "distributionTable";
      this.distributionTable.RowCount = 1;
      this.distributionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
      this.distributionTable.Size = new System.Drawing.Size(156, 18);
      this.distributionTable.TabIndex = 1;
      this.distributionTable.MouseEnter += new System.EventHandler(this.scrollPanel_MouseEnter);
      // 
      // DistributionDisplay
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.scrollPanel);
      this.Name = "DistributionDisplay";
      this.Size = new System.Drawing.Size(219, 150);
      this.scrollPanel.ResumeLayout(false);
      this.scrollPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel scrollPanel;
    private System.Windows.Forms.TableLayoutPanel distributionTable;
  }
}
