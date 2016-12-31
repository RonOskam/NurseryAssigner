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
using System.Reflection;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;
using NurseryAssigner.Win.Reports;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Data.Entity.Core.Common;

namespace NurseryAssigner.Win
{
  public partial class MainForm : Form
  {
    private readonly Color _selectedColor = Color.HotPink;
    private NurseryAssignerEntities _db = null;
    private Label _selectedItem = null;

    public MainForm()
    {
      InitializeComponent();

      distributionDisplay.AttendantSelected += DistributionDisplay_AttendantSelected;
    }

    private void DistributionDisplay_AttendantSelected(object sender, EventArgs e)
    {
      if (distributionDisplay.SelectedAttendant.HasValue)
        setCellColors(distributionDisplay.SelectedAttendant.Value);
    }

    private bool loadByRange()
    {
      return loadByRange(Properties.Settings.Default.StartDate, Properties.Settings.Default.EndDate);
    }

    private bool loadByRange(DateTime startDate, DateTime endDate)
    {
      startDateLabel.Text = startDate.ToShortDateString();
      endDateLabel.Text = endDate.ToShortDateString();

      var days = _db.Services.Include("AttendantSchedules.Attendant").Where(s => s.Date >= startDate && s.Date <= endDate)
        .OrderBy(s => s.Date).ThenBy(s => s.AMPM).ToList();

      if (!days.Any())
        return false;
      else
      {
        scheduleTable.SuspendLayout();
        scheduleTable.Controls.Clear();
        scheduleTable.RowCount = 1;
        int row = 0;
        var font = new Font(scheduleTable.Font, FontStyle.Bold);
        foreach (var day in days)
        {
          var newRowStyle = new RowStyle(SizeType.Absolute, 20);
          scheduleTable.RowStyles.Add(newRowStyle);
          addLabel(day.Date.ToString("MMM d"), 0, row, font);
          addLabel(day.AMPM, 1, row, font);
          for (int x = 1; x <= Attendant.MaxAttendantsPerDay(_db); x++)
          {
            var schedule = day.AttendantSchedules.FirstOrDefault(s => s.Position == x);
            if (schedule != null)
              addPerson(schedule, x + 1, row);
            else
              addLabel("", x + 1, row);
          }
          row++;
          scheduleTable.RowCount++;
        }
        setCellColors(null);
        scheduleTable.ResumeLayout();

        distributionDisplay.DisplayCounts(startDate, endDate);

        return true;
      }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
    
    }

    public static NurseryAssignerEntities DatabaseConnection()
    {
      var file = Properties.Settings.Default.FileLocation;
      return new NurseryAssignerEntities(file);
    }

    private bool setDBConnectionAndLoad()
    {
      var file = Properties.Settings.Default.FileLocation;
      if (string.IsNullOrWhiteSpace(file))
      {
        if (!openDatabaseFile())
          return false;
      }
      if (_db != null)
        _db.Database.Connection.Close();

      _db = new NurseryAssignerEntities(file);
      this.Text = "Nursery Assigner - " + System.IO.Path.GetFileName(file);

      loadByRange();
      return true;
    }

    private void MainForm_Shown(object sender, EventArgs e)
    {
      if (setDBConnectionAndLoad())
      {
        var count = Attendant.MaxAttendantsPerDay(_db);
        for (int x = 1; x <= count; x++)
        {
          var style = new ColumnStyle(SizeType.Absolute, 125);
          scheduleTable.ColumnStyles.Add(style);
          scheduleTable.ColumnCount++;
        }

        if (Properties.Settings.Default.MainFormHeight != 0)
        {
          Height = Properties.Settings.Default.MainFormHeight;
          Width = Properties.Settings.Default.MainFormWidth;
          Left = Properties.Settings.Default.MainFormX;
          Top = Properties.Settings.Default.MainFormY;
        }

        if (Properties.Settings.Default.StartDate == DateTime.MinValue)
          selectToolStripMenuItem_Click(null, EventArgs.Empty);
        else
          loadByRange();
      }
    }

    private void addLabel(string text, int column, int row, Font font = null)
    {
      var label = new Label();
      label.Text = text;
      label.Dock = DockStyle.Fill;
      label.Margin = new Padding(0);
      label.TextAlign = ContentAlignment.MiddleLeft;
      if (font != null)
        label.Font = font;
      scheduleTable.Controls.Add(label, column, row);
    }

    private void addPerson(AttendantSchedule schedule, int column, int row)
    {
      var label = new Label();
      label.Text = schedule.Attendant.FullName;
      label.Tag = schedule;

      label.Margin = new Padding(0);
      label.TextAlign = ContentAlignment.MiddleLeft;
      label.AllowDrop = true;
      label.Dock = DockStyle.Fill;
      label.MouseDown += Label_MouseDown;
      label.DragEnter += Label_DragEnter;
      label.DragLeave += Label_DragLeave;
      label.DragDrop += Label_DragDrop;

      scheduleTable.Controls.Add(label, column, row);
    }

    private void Label_DragDrop(object sender, DragEventArgs e)
    {
      var source = (Label)e.Data.GetData(typeof(Label));
      var destination = (Label)sender;

      if (source.Text != destination.Text
        && MessageBox.Show("Are you sure you want to swap " + source.Text + " and " + destination.Text + "?", Application.ProductName, MessageBoxButtons.OKCancel) == DialogResult.OK)
      {
        var swap = source.Text;
        source.Text = destination.Text;
        destination.Text = swap;

        var destSched = (AttendantSchedule)destination.Tag;      
        destination.BackColor = _selectedColor;

        var sourceSched = (AttendantSchedule)source.Tag;
        var swapAttendant = destSched.Attendant;
        destSched.Attendant = sourceSched.Attendant;
        sourceSched.Attendant = swapAttendant;

        _db.SaveChanges();
        distributionDisplay.UpdateDisplay();

        setCellColors(destSched.AttendantID);
      }
      else
        destination.BorderStyle = BorderStyle.None;
    }

    private void Label_DragEnter(object sender, DragEventArgs e)
    {
      var source = (Label)e.Data.GetData(typeof(Label));
      var destination = (Label)sender;
      if (source.Text != destination.Text)
      {
        e.Effect = DragDropEffects.Move;
        ((Label)sender).BorderStyle = BorderStyle.FixedSingle;
      }
    }

    private void Label_DragLeave(object sender, EventArgs e)
    {
      ((Label)sender).BorderStyle = BorderStyle.None;
    }

    private void Label_MouseDown(object sender, MouseEventArgs e)
    {
      var label = (Label)sender;

      var currentSched = (AttendantSchedule)(((Label)sender).Tag);
      if (e.Button == MouseButtons.Left)
      {
        _selectedItem = label;
        setCellColors(currentSched.AttendantID);
        label.BackColor = _selectedColor;
        distributionDisplay.SelectAttendant(currentSched.AttendantID);

        label.DoDragDrop(label, DragDropEffects.Move);
      }
      else if (e.Button == MouseButtons.Right && label.BackColor == _selectedColor)
      {
        setupContextMenu(currentSched.Attendant);
        attendantMenu.Show(label, 0, 20);
      }
    }

    private void setupContextMenu(Attendant attendant)
    {
      attendantMenu.Items.Clear();

      //add people from the same age group
      var list = _db.Attendants.Where(a => !a.IsInactive && a.AgeGroupID == attendant.AgeGroupID).OrderBy(a => a.LastName)
        .ThenBy(a => a.FirstName).ToList();
      foreach (var item in list)
      {
        var menuItem = new ToolStripMenuItem(item.LastFirst);
        menuItem.Checked = (attendant.ID == item.ID);
        menuItem.Tag = item;
        menuItem.Click += ChangePerson_Click;
        attendantMenu.Items.Add(menuItem);
      }

      //add sub menu items for people from other age groups
      attendantMenu.Items.Add(new ToolStripSeparator());
      var otherGroups = _db.AgeGroups.Where(g => g.ID != attendant.AgeGroupID).ToList();
      foreach (var item in otherGroups)
      {
        var menuItem = new ToolStripMenuItem(item.Name);
        attendantMenu.Items.Add(menuItem);

        var otherAttendants = _db.Attendants.Where(a => !a.IsInactive && a.AgeGroupID == item.ID).OrderBy(a => a.LastName)
          .ThenBy(a => a.FirstName).ToList();
        foreach (var other in otherAttendants)
        {
          var subItem = new ToolStripMenuItem(other.LastFirst);
          subItem.Tag = other;
          subItem.Click += ChangePerson_Click;
          menuItem.DropDownItems.Add(subItem);
        }
      }
    }

    private void ChangePerson_Click(object sender, EventArgs e)
    {
      var destination = (Attendant)(((ToolStripMenuItem)sender).Tag);
      var source = (AttendantSchedule)_selectedItem.Tag;

      _selectedItem.Text = destination.FullName;
      source.Attendant = destination;
      source.AttendantID = destination.ID;

      _db.SaveChanges();
      distributionDisplay.UpdateDisplay();
    }

    private void setCellColors(long? selectedAttendantID)
    {
      foreach (var item in scheduleTable.Controls)
      {
        if (item is Label)
        {
          var label = (Label)item;

          label.BorderStyle = BorderStyle.None;
          var itemSched = (AttendantSchedule)label.Tag;
          if (!selectedAttendantID.HasValue || itemSched == null || itemSched.AttendantID != selectedAttendantID.Value)
          {
            var row = scheduleTable.GetRow(label);
            if (row % 2 == 0)   //alternate row colors
              label.BackColor = Color.Transparent;
            else
              label.BackColor = Color.Gainsboro;
          }
          else
            label.BackColor = Color.Pink;
        }
      }
    }

    private void assignmentCountToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var dialog = new AssignmentCountDialog();
      dialog.ShowDialog();
    }

    private void ageGroupsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var dialog = new AgeGroupDialog();
      dialog.ShowDialog();
    }

    private void attendantsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var dialog = new AttendantDialog();
      dialog.ShowDialog();
    }

    private void additonalDayToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var dialog = new AdditionalServiceDialog();
      dialog.ShowDialog();
    }

    private void selectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var dialog = new DateRangeDialog();

      if (dialog.ShowDialog() == DialogResult.OK)
      {
        var startDate = Properties.Settings.Default.StartDate;
        var endDate = Properties.Settings.Default.EndDate;

        if (!loadByRange(startDate, endDate))
        {
          if (MessageBox.Show("There is nothing scheduled for this range, do you want create a schedule for it?", Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
          {
            var builder = new ScheduleBuilder(_db, startDate, endDate);
            builder.BuildSchedule();
            loadByRange(startDate, endDate);
          }
        }
      }
    }

    private void scrollPanel_MouseEnter(object sender, EventArgs e)
    {
      scrollPanel.Focus();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Properties.Settings.Default.MainFormHeight = Height;
      Properties.Settings.Default.MainFormWidth = Width;
      Properties.Settings.Default.MainFormX = Left;
      Properties.Settings.Default.MainFormY = Top;
      Properties.Settings.Default.Save();
    }

    private void buildScheduleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var builder = new ScheduleBuilder(_db, Properties.Settings.Default.StartDate, Properties.Settings.Default.EndDate);
      if (builder.BeenScheduled && MessageBox.Show("Are you sure you want to overwrite the schedule for this date range?", Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.No)
        return;

      builder.BuildSchedule();
      loadByRange();
    }

    private void attendantScheduleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var source = _db.AttendantSchedules.Where(s => s.Service.Date >= Properties.Settings.Default.StartDate && s.Service.Date <= Properties.Settings.Default.EndDate)
  .OrderBy(s => s.Service.Date).ThenBy(s => s.Service.AMPM).ToList();

      var report = new AttendantScheduleReport();
      report.DataSource = source;

      using (ReportPrintTool printTool = new ReportPrintTool(report))
      {
        printTool.ShowRibbonPreviewDialog();
      }
    }

    private void familySummaryToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var source = AttendantSummary.Load(_db, Properties.Settings.Default.StartDate, Properties.Settings.Default.EndDate);
      var report = new FamilySummaryReport();
      report.DataSource = source;

      using (ReportPrintTool printTool = new ReportPrintTool(report))
      {
        printTool.ShowRibbonPreviewDialog();
      }
    }

    private void attendantListToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var source = _db.Attendants.Where(a => !a.IsInactive).OrderBy(a => a.AgeGroupID).ThenBy(a => a.LastName).ThenBy(a => a.FirstName).ToList();
      var report = new AttendantListReport();
      report.DataSource = source;

      using (ReportPrintTool printTool = new ReportPrintTool(report))
      {
        printTool.ShowRibbonPreviewDialog();
      }
    }

    private void openToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (openDatabaseFile())
        setDBConnectionAndLoad();
    }

    private bool openDatabaseFile()
    {
      var dialog = new OpenFileDialog();
      dialog.DefaultExt = "sqlite";
      dialog.Title = "Select Nursury Assigner Data File";
      dialog.Filter = "SQLite File|*.sqlite";
      if (dialog.ShowDialog() == DialogResult.OK)
      {
        Properties.Settings.Default.FileLocation = dialog.FileName;
        Properties.Settings.Default.Save();
        return true;
      }
      else
        return false;
    }

  }

}
