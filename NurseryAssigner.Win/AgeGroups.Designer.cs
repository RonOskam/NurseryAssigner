namespace NurseryAssigner.Win
{
  partial class AgeGroupDialog
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
      this.groupGridView = new System.Windows.Forms.DataGridView();
      this.button1 = new System.Windows.Forms.Button();
      this.okButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // groupGridView
      // 
      this.groupGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.groupGridView.Location = new System.Drawing.Point(0, 0);
      this.groupGridView.MultiSelect = false;
      this.groupGridView.Name = "groupGridView";
      this.groupGridView.RowHeadersWidth = 25;
      this.groupGridView.Size = new System.Drawing.Size(284, 215);
      this.groupGridView.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button1.Location = new System.Drawing.Point(197, 226);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Cancel";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // okButton
      // 
      this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.okButton.Location = new System.Drawing.Point(116, 226);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 2;
      this.okButton.Text = "OK";
      this.okButton.UseVisualStyleBackColor = true;
      this.okButton.Click += new System.EventHandler(this.okButton_Click);
      // 
      // AgeGroupDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.groupGridView);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AgeGroupDialog";
      this.Text = "Age Groups";
      this.Load += new System.EventHandler(this.AgeGroups_Load);
      ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView groupGridView;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button okButton;
  }
}