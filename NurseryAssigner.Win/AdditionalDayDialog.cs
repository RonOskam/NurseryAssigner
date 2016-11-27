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
  public partial class AdditionalServiceDialog : Form
  {
    public AdditionalServiceDialog()
    {
      InitializeComponent();

      _db.AdditionalServices.LoadAsync().ContinueWith(loadTask =>
      {
        // Bind data to control when loading complete
        gridControl.DataSource = _db.AdditionalServices.Local.ToBindingList();
      }, TaskScheduler.FromCurrentSynchronizationContext());
    }

    private NurseryAssignerEntities _db = new NurseryAssignerEntities();

    private void AdditionalServices_Load(object sender, EventArgs e)
    {
      var list = new List<string>();
      list.Add("AM");
      list.Add("PM");
      ampmLookUpEdit.DataSource = list;
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
      var record = new AdditionalService();
      record.AMPM = "AM";

      _db.AdditionalServices.Add(record);
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
      gridView.DeleteSelectedRows();
    }

  }
}
