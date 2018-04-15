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
  public partial class DateRangeDialog : Form
  {
    public DateRangeDialog()
    {
      InitializeComponent();
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      if (dateEditStart.DateTime >= dateEditEnd.DateTime)
      {
        MessageBox.Show("The Start Date must be before the End Date.");
          this.DialogResult = DialogResult.None;
      }
      else
      {
        Properties.Settings.Default.StartDate = dateEditStart.DateTime;
        Properties.Settings.Default.EndDate = dateEditEnd.DateTime;
        Properties.Settings.Default.Save();
      }
    }

    private void DateRangeDialog_Load(object sender, EventArgs e)
    {
      if (Properties.Settings.Default.StartDate != DateTime.MinValue)
      {
        dateEditStart.DateTime = Properties.Settings.Default.StartDate;
        dateEditEnd.DateTime = Properties.Settings.Default.EndDate;
      }
    }

  }
}
