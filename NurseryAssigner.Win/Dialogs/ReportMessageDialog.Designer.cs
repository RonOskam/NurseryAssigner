namespace NurseryAssigner.Win
{
  partial class ReportMessageDialog
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
      this.okButton = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.messageTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // okButton
      // 
      this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.okButton.Location = new System.Drawing.Point(217, 192);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(60, 23);
      this.okButton.TabIndex = 14;
      this.okButton.Text = "Save";
      this.okButton.UseVisualStyleBackColor = true;
      this.okButton.Click += new System.EventHandler(this.okButton_Click);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button1.Location = new System.Drawing.Point(283, 192);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(60, 23);
      this.button1.TabIndex = 13;
      this.button1.Text = "Cancel";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // messageTextBox
      // 
      this.messageTextBox.AcceptsReturn = true;
      this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.messageTextBox.Location = new System.Drawing.Point(13, 12);
      this.messageTextBox.Multiline = true;
      this.messageTextBox.Name = "messageTextBox";
      this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.messageTextBox.Size = new System.Drawing.Size(330, 174);
      this.messageTextBox.TabIndex = 15;
      // 
      // ReportMessageDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(355, 227);
      this.ControlBox = false;
      this.Controls.Add(this.messageTextBox);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.button1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ReportMessageDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Attendant Schedule Message";
      this.Load += new System.EventHandler(this.ReportMessageDialog_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox messageTextBox;
  }
}