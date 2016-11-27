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
using System.Collections;
using System.Data.Entity;

namespace NurseryAssigner.Win
{
  public partial class AgeGroupDialog : Form
  {
    public AgeGroupDialog()
    {
      InitializeComponent();

      _db.AgeGroups.LoadAsync().ContinueWith(loadTask =>
      {
        // Bind data to control when loading complete
        gridControl.DataSource = _db.AgeGroups.Local.ToBindingList();
      }, TaskScheduler.FromCurrentSynchronizationContext());
    }

    private NurseryAssignerEntities _db = new NurseryAssignerEntities();
    
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
      var record = new AgeGroup();
      _db.AgeGroups.Add(record);
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
      gridView.DeleteSelectedRows();
    }
  }
}
