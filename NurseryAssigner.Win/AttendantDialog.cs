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
  public partial class AttendantDialog : Form
  {
    public AttendantDialog()
    {
      InitializeComponent();
    }

    private NurseryAssignerEntities _db = new NurseryAssignerEntities();

    private void AttendantDialog_Load(object sender, EventArgs e)
    {
      var list = _db.Attendants.OrderBy(c => c.LastName).ThenBy(c => c.FirstName).ToList();
      LoadData(list);
    }

    private List<Attendant> DataSource
    {
      get
      {
        return (List<Attendant>)groupGridView.DataSource;
      }
      set
      {
        groupGridView.DataSource = value;
      }
    }

    private void LoadData(List<Attendant> source)
    {
      DataSource = null;
      DataSource = source;

      groupGridView.Columns.Clear();

      var firstColumn = new DataGridViewTextBoxColumn();
      firstColumn.HeaderText = "First Name";
      firstColumn.DataPropertyName = "FirstName";
      firstColumn.Width = 85;
      groupGridView.Columns.Add(firstColumn);

      var lastColumn = new DataGridViewTextBoxColumn();
      lastColumn.HeaderText = "Last Name";
      lastColumn.DataPropertyName = "LastName";
      groupGridView.Columns.Add(lastColumn);

      var genderColumn = new DataGridViewComboBoxColumn();
      genderColumn.DataSource = new string[] { "M", "F" };
      genderColumn.DataPropertyName = "Gender";
      genderColumn.HeaderText = "Gender";
      genderColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
      genderColumn.Width = 50;
      groupGridView.Columns.Add(genderColumn);

      var groupColumn = new DataGridViewComboBoxColumn();
      groupColumn.DataSource = _db.AgeGroups.ToList();
      groupColumn.HeaderText = "Age Group";
      groupColumn.DataPropertyName = "AgeGroupID";
      groupColumn.ValueMember = "ID";
      groupColumn.DisplayMember = "Name";
      groupColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
      groupGridView.Columns.Add(groupColumn);

      var amColumn = new DataGridViewCheckBoxColumn(false);
      amColumn.DataPropertyName = "DoesAM";
      amColumn.HeaderText = "Does AM";
      amColumn.Width = 60;
      groupGridView.Columns.Add(amColumn);

      var pmColumn = new DataGridViewCheckBoxColumn(false);
      pmColumn.DataPropertyName = "DoesPM";
      pmColumn.HeaderText = "Does PM";
      pmColumn.Width = 60;
      groupGridView.Columns.Add(pmColumn);

      var yearColumn = new DataGridViewTextBoxColumn();
      yearColumn.HeaderText = "Grad Year";
      yearColumn.DataPropertyName = "GradYear";
      yearColumn.Width = 80;
      groupGridView.Columns.Add(yearColumn);

      var startColumn = new DataGridViewTextBoxColumn();
      startColumn.HeaderText = "Exclusion Start";
      startColumn.DataPropertyName = "ExclusionStart";
      //startColumn.Width = 95;
      groupGridView.Columns.Add(startColumn);

      var endColumn = new DataGridViewTextBoxColumn();
      endColumn.HeaderText = "Exclusion End";
      endColumn.DataPropertyName = "ExclusionEnd";
      //endColumn.Width = 95;
      groupGridView.Columns.Add(endColumn);

      var inactiveColumn = new DataGridViewCheckBoxColumn();
      inactiveColumn.DataPropertyName = "IsInactive";
      inactiveColumn.HeaderText = "Inactive";
      inactiveColumn.Width = 60;
      groupGridView.Columns.Add(inactiveColumn);

      var commentColumn = new DataGridViewTextBoxColumn();
      commentColumn.HeaderText = "Comment";
      commentColumn.DataPropertyName = "Comment";
      commentColumn.Width = 150;
      groupGridView.Columns.Add(commentColumn);
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
      var record = new Attendant();
      record.AgeGroupID = 1;
      DataSource.Add(record);
      _db.Attendants.Add(record);
      LoadData(DataSource);
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
      if (groupGridView.CurrentRow != null)
      {
        var row = (Attendant)(groupGridView.CurrentRow.DataBoundItem);
        DataSource.Remove(row);
        _db.Attendants.Remove(row);
        LoadData(DataSource);
      }
    }
  }
}
