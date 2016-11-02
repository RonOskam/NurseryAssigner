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
      LoadData(_db.AgeGroups.ToList());
    }

    private List<AgeGroup> DataSource
    {
      get
      {
        return (List<AgeGroup>)groupGridView.DataSource;
      }
      set
      {
        groupGridView.DataSource = value;
      }
    }

    private void LoadData(List<AgeGroup> source)
    {
      DataSource = null;
      DataSource = source; 
      groupGridView.Columns[0].Visible = false;
      groupGridView.Columns[2].Visible = false;
      groupGridView.Columns[3].Visible = false; 
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      try
      {
        _db.SaveChanges();
      }
      catch(Exception err)
      {
        MessageBox.Show("Could not save changes: \r\n\r\n" + err.Message, Application.ProductName);
        this.DialogResult = DialogResult.None;
      }
    }

    private void addButton_Click(object sender, EventArgs e)
    {
      var record = new AgeGroup();
      DataSource.Add(record);
      _db.AgeGroups.Add(record);
      LoadData(DataSource);
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
      if (groupGridView.CurrentRow != null)
      {
        var row = (AgeGroup)(groupGridView.CurrentRow.DataBoundItem);
        DataSource.Remove(row);
        _db.AgeGroups.Remove(row);
        LoadData(DataSource);
      }
    }

  }
}
