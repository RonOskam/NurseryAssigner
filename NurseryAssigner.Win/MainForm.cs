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
      var db = new NurseryAssignerEntities();
      var days = db.ScheduledDays.Where(s => s.Date >= startDate && s.Date <= endDate)
        .OrderBy(s => s.Date).ThenBy(s => s.AMPM).ToList();

      scheduleTable.SuspendLayout();
      int row = 1;
      foreach (var day in days)
      {
        scheduleTable.RowCount++;
        var newRowStyle = new RowStyle(SizeType.Absolute, 20);
        scheduleTable.RowStyles.Add(newRowStyle);
        addLabel(day.Date.ToString("MMM d"), 0, row);
        addLabel(day.AMPM, 1, row);
        foreach (var schedule in day.AttendantSchedules.OrderBy(s => s.Position))
          addPerson(schedule, Convert.ToInt32(schedule.Position) + 1, row);

        row++;
      }
      scheduleTable.ResumeLayout();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      var font = new Font(scheduleTable.Font, FontStyle.Bold);

      addLabel("Date", 0, 0, font);
      addLabel("A/P", 1, 0, font);
      addLabel("First Adult", 2, 0, font);
      addLabel("Second Adult", 3, 0, font);
      addLabel("Third Adult", 4, 0, font);
      addLabel("Middle School", 5, 0, font);
      addLabel("Elementary", 6, 0, font);
    }

    private void addLabel(string text, int column, int row, Font font = null)
    {
      var label = new Label();
      label.Text = text;
      label.Dock = DockStyle.Fill;
      label.TextAlign = ContentAlignment.MiddleLeft;
      if (font != null)
        label.Font = font;
      scheduleTable.Controls.Add(label, column, row);
    }

    private void addPerson(AttendantSchedule schedule, int column, int row)
    {
      var label = new Label();
      label.Text = schedule.Attendant.FirstName + " " + schedule.Attendant.LastName;
      label.Tag = schedule;
      label.Dock = DockStyle.Fill;
      label.TextAlign = ContentAlignment.MiddleLeft;
      label.AllowDrop = true;
      label.MouseDown += Label_MouseDown;
      label.DragEnter += Label_DragEnter;
      label.DragDrop += Label_DragDrop;
      scheduleTable.Controls.Add(label, column, row);
    }

    private void Label_DragDrop(object sender, DragEventArgs e)
    {    
      var source = (Label)e.Data.GetData(typeof(Label));
      var destination = (Label)sender;

      if (source.Text != destination.Text 
        && MessageBox.Show("Are you sure you want to swap " + source.Text + " with " + destination.Text + "?", Application.ProductName, MessageBoxButtons.OKCancel) == DialogResult.OK)
      {
        var swap = source.Text;
        source.Text = destination.Text;
        destination.Text = swap;

        var tagSwap = source.Tag;
        source.Tag = destination.Tag;
        destination.Tag = tagSwap;

        var destSched = (AttendantSchedule)destination.Tag;
        SetSelection(destSched.AttendantID);
        destination.BackColor = Color.HotPink;
      }
    }

    private void Label_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.Move;
    }

    private void Label_MouseDown(object sender, MouseEventArgs e)
    {
      var label = (Label)sender;      
      var currentSched = (AttendantSchedule)(((Label)sender).Tag);

      SetSelection(currentSched.AttendantID);
      label.BackColor = Color.HotPink;

      label.DoDragDrop(label, DragDropEffects.Move);
    }

    private void SetSelection(long? attendantID)
    {
      foreach (var item in scheduleTable.Controls)
      {
        if (item is Label && ((Label)item).Tag != null)
        {
          var label = (Label)item;
          var itemSched = (AttendantSchedule)label.Tag;
          if (!attendantID.HasValue || itemSched.AttendantID != attendantID.Value)
            label.BackColor = Color.Transparent;
          else
            label.BackColor = Color.Pink;
        }
      }
    }
  }
}
