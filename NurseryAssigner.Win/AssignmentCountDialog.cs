using NurseryAssigner.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace NurseryAssigner.Win
{
  public partial class AssignmentCountDialog : Form
  {
    public AssignmentCountDialog()
    {
      InitializeComponent();
      
      _db.AssignmentCounts.LoadAsync().ContinueWith(loadTask =>
      {
        // Bind data to control when loading complete
        gridControl.DataSource = _db.AssignmentCounts.Local.ToBindingList();
      }, TaskScheduler.FromCurrentSynchronizationContext());
    }

    private NurseryAssignerEntities _db = new NurseryAssignerEntities();

    private void AssignmentCountDialog_Load(object sender, EventArgs e)
    {
      var list = new List<string>();
      list.Add("AM");
      list.Add("PM");
      ampmLookUpEdit.DataSource = list;

      ageGroupLookUpEdit.DataSource = _db.AgeGroups.ToList();
      ageGroupLookUpEdit.DisplayMember = "Name";
      ageGroupLookUpEdit.ValueMember = "ID";
      ageGroupLookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name"));
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      try
      {
        _db.SaveChanges();
      }
      catch (Exception err)
      {
        MessageBox.Show("Could not save changes: \r\n\r\n" + err.Message, Application.ProductName);
        this.DialogResult = DialogResult.None;
      }
    }

    private void addButton_Click(object sender, EventArgs e)
    {
      var record = new AssignmentCount();
      record.AMPM = "AM";
      record.AgeGroupID = 1;
 
      _db.AssignmentCounts.Add(record);
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
      gridView.DeleteSelectedRows();
    }

  }
}
