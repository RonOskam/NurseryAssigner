using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurseryAssigner.Win
{
  public partial class ReportMessageDialog : Form
  {
    public ReportMessageDialog()
    {
      InitializeComponent();
    }

    private void ReportMessageDialog_Load(object sender, EventArgs e)
    {
      var db = MainForm.DatabaseConnection();
      var message = db.Parameters.Find(1).Value;
      messageTextBox.Text = message;
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      var db = MainForm.DatabaseConnection();
      var record = db.Parameters.Find(1);
      record.Value = messageTextBox.Text;
      db.SaveChanges();
    }
  }
}
