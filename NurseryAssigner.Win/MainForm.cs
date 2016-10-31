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

namespace NurseryAssigner.Win
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void loadButton_Click(object sender, EventArgs e)
    {
      var startDate = new DateTime(2016, 7, 1);
      var endDate = new DateTime(2016, 12, 31);

      loadByRange(startDate, endDate);
    }

    private int maxAttendantsPerDay
    {
      get
      {
        var db = new NurseryAssignerEntities();
        long count = db.AssignmentCounts.GroupBy(c => c.AMPM).Select(g => g.Sum(v => v.Amount)).Max();
        return Convert.ToInt32(count);
      }
    }

    private void loadByRange(DateTime startDate, DateTime endDate)
    {
      var db = new NurseryAssignerEntities();
      var days = db.ScheduledDays.Where(s => s.Date >= startDate && s.Date <= endDate)
        .OrderBy(s => s.Date).ThenBy(s => s.AMPM).ToList();

      scheduleTable.SuspendLayout();
      int row = 0;
      var font = new Font(scheduleTable.Font, FontStyle.Bold);
      foreach (var day in days)
      {
        var newRowStyle = new RowStyle(SizeType.Absolute, 20);
        scheduleTable.RowStyles.Add(newRowStyle);
        addLabel(day.Date.ToString("MMM d"), 0, row, font);
        addLabel(day.AMPM, 1, row, font);
        for (int x = 1; x <= maxAttendantsPerDay; x++)
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
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      var count = maxAttendantsPerDay;
      for (int x = 1; x <= count; x++)
      {
        var style = new ColumnStyle(SizeType.Absolute, 125);
        scheduleTable.ColumnStyles.Add(style);
        scheduleTable.ColumnCount++;
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

        var tagSwap = source.Tag;
        source.Tag = destination.Tag;
        destination.Tag = tagSwap;

        var destSched = (AttendantSchedule)destination.Tag;
        setCellColors(destSched.AttendantID);
        destination.BackColor = Color.HotPink;
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
        setCellColors(currentSched.AttendantID);
        label.BackColor = Color.HotPink;
        label.Parent.Controls[1].Visible = true;

        label.DoDragDrop(label, DragDropEffects.Move);
      }
      else if (e.Button == MouseButtons.Right)
      {
        setupContextMenu(currentSched.Attendant);
        attendantMenu.Show(label, 0, 20);
      }
    }

    private void setupContextMenu(Attendant attendant)
    {
      attendantMenu.Items.Clear();

      var db = new NurseryAssignerEntities();
      var list = db.Attendants.Where(a => !a.IsInactive && a.AgeGroupID == attendant.AgeGroupID).OrderBy(a => a.LastName)
        .ThenBy(a => a.FirstName).ToList();
      foreach (var item in list)
      {
        var menuItem = new ToolStripMenuItem(item.LastFirst);
        menuItem.Checked = (attendant.ID == item.ID);
        attendantMenu.Items.Add(menuItem);
      }
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

    }
  }
}
