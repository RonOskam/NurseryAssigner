using NurseryAssigner.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurseryAssigner.Win
{
  public partial class AttendantDialog : Form
  {
    public AttendantDialog()
    {
      InitializeComponent();

      _db = MainForm.DatabaseConnection();
      _db.Attendants.LoadAsync().ContinueWith(loadTask =>
      {
        // Bind data to control when loading complete
        gridControl.DataSource = _db.Attendants.Local.ToBindingList().OrderBy(a => a.LastName).ThenBy(a => a.FirstName);
      }, TaskScheduler.FromCurrentSynchronizationContext());
    }

    private NurseryAssignerEntities _db = null;

    private void AttendantDialog_Load(object sender, EventArgs e)
    {
      var list = new List<string>();
      list.Add("M");
      list.Add("F");
      genderLookUpEdit.DataSource = list;

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
