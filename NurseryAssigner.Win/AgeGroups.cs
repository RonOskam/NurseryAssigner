using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NurseryAssigner.Data;

namespace NurseryAssigner.Win
{
  public partial class AgeGroupDialog : Form
  {
    public AgeGroupDialog()
    {
      InitializeComponent();
    }

    private NurseryAssignerEntities _db = new NurseryAssignerEntities();

    private void AgeGroups_Load(object sender, EventArgs e)
    {
      groupGridView.DataSource = _db.AgeGroups.ToList(); 
      groupGridView.Columns[0].Visible = false;
      groupGridView.Columns[2].Visible = false;
      groupGridView.Columns[3].Visible = false;
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      _db.SaveChanges();
    }
  }
}
