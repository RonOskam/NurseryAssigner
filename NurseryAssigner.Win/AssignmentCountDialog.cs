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

namespace NurseryAssigner.Win
{
  public partial class AssignmentCountDialog : Form
  {
    public AssignmentCountDialog()
    {
      InitializeComponent();
  
    }

    private NurseryAssignerEntities _db = new NurseryAssignerEntities();

    private void AssignmentCountDialog_Load(object sender, EventArgs e)
    {
      LoadData(_db.AssignmentCounts.OrderBy(c => c.AMPM).ThenBy(c => c.AgeGroupID).ToList());
    }

    private List<AssignmentCount> DataSource
    {
      get
      {
        return (List<AssignmentCount>)groupGridView.DataSource;
      }
      set
      {
        groupGridView.DataSource = value;
      }
    }

    private void LoadData(List<AssignmentCount> source)
    {
      DataSource = null;
      DataSource = source;

      groupGridView.Columns.Clear();

      var apColumn = new DataGridViewComboBoxColumn();
      apColumn.DataSource = new string[] { "AM", "PM" };
      apColumn.DataPropertyName = "AMPM";
      apColumn.HeaderText = "AMPM";
      apColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
      
      groupGridView.Columns.Add(apColumn);

      var groupColumn = new DataGridViewComboBoxColumn();
      groupColumn.DataSource = _db.AgeGroups.ToList();
      groupColumn.HeaderText = "Age Group";
      groupColumn.DataPropertyName = "AgeGroupID";
      groupColumn.ValueMember = "ID";
      groupColumn.DisplayMember = "Name";
      groupColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
      groupGridView.Columns.Add(groupColumn);

      var amountColumn = new DataGridViewTextBoxColumn();
      amountColumn.HeaderText = "Count";
      amountColumn.DataPropertyName = "Amount";
      groupGridView.Columns.Add(amountColumn);
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
      DataSource.Add(record);
      _db.AssignmentCounts.Add(record);
      LoadData(DataSource);
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
      if (groupGridView.CurrentRow != null)
      {
        var row = (AssignmentCount)(groupGridView.CurrentRow.DataBoundItem);
        DataSource.Remove(row);
        _db.AssignmentCounts.Remove(row);
        LoadData(DataSource);
      }
    }

  }
}
