using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryAssigner.Data
{

  public class ScheduleBuilder
  {
    private NurseryAssignerEntities _db = new NurseryAssignerEntities();
    private DateTime _start;
    private DateTime _end;
    private Dictionary<long, List<Attendant>> _attendants;
    private Dictionary<long, int> _listPos;

    public ScheduleBuilder(DateTime start, DateTime end)
    {
      _start = start;
      _end = end;
    }

    public bool BeenScheduled
    {
      get
      {
        return _db.AttendantSchedules.Any(s => s.Service.Date >= _start && s.Service.Date <= _end);
      }
    }
    
    public void BuildSchedule()
    {
      clearSchedule();
      loadServices();
      loadAttendants();

      var list = _db.Services.Where(d => d.Date >= _start && d.Date <= _end).ToList();
      foreach (var item in list)
        fillService(item);

      _db.SaveChanges();
    }

    private void clearSchedule()
    {
      var schedules = _db.AttendantSchedules.Where(s => s.Service.Date >= _start && s.Service.Date <= _end).ToList();
      _db.AttendantSchedules.RemoveRange(schedules);

      var days = _db.Services.Where(d => d.Date >= _start && d.Date <= _end).ToList();
      _db.Services.RemoveRange(days);
    }

    private void loadServices()
    {
      //add Sundays
      for (var date = _start; _start <= _end; _start = _start.AddDays(1))
      {
        if (date.DayOfWeek == DayOfWeek.Sunday)
        {
          insertService(date, "AM");
          insertService(date, "PM");
        }
      }

      //add additional days
      var list = _db.AdditionalServices.Where(d => d.Date >= _start && d.Date <= _end).ToList();
      foreach (var item in list)
        insertService(item.Date, item.AMPM);
    }

    private void insertService(DateTime day, string service)
    {
      if (!_db.Services.Any(s => s.Date == day && s.AMPM == service))
      {
        var record = new Service();
        record.Date = day;
        record.AMPM = service;
        _db.Services.Add(record);
      }
    }

    private void fillService(Service service)
    {
      var counts = _db.AssignmentCounts.Where(c => c.AMPM == service.AMPM).ToList();
      long pos = 1;
      foreach (var item in counts)
      {
        for (var x = 1; x <= item.Amount; x++)
        {
          var attendantID = attendantForService(item.AgeGroupID, service.Date, service.AMPM);
          var record = new AttendantSchedule();
          record.AttendantID = attendantID;
          record.Position = pos;
          service.AttendantSchedules.Add(record);

          pos++;
        }
      }
    }

    private long attendantForService(long groupID, DateTime date, string service)
    {
      var attendant = attendantFromList(groupID);
      return attendant.ID;
    }

    private Attendant attendantFromList(long groupID)
    {
      var list = _attendants[groupID];
      var index = _listPos[groupID];
      var result = list[index];

      if (index == list.Count - 1)
      {
        //reached the end of the list, so randomize it and set the counter back to 0
        randomizeAttendants(ref list);
        _attendants[groupID] = list;
        _listPos[groupID] = 0;
      }
      else
      _listPos[groupID]++;
      
      return result;
    }

    private void loadAttendants()
    {
      _attendants = new Dictionary<long, List<Attendant>>();

      foreach (var item in _db.AgeGroups.ToList())
      {
        var list = item.Attendants.Where(a => !a.IsInactive).ToList();
        randomizeAttendants(ref list);
        _attendants.Add(item.ID, list);
        _listPos.Add(item.ID, 0);
      }
    }

    private void randomizeAttendants(ref List<Attendant> list)
    {
      var randomizer = new Random();
      for (var x = 0; x < 50; x++)
      {
        var pos1 = randomizer.Next(list.Count);
        var pos2 = randomizer.Next(list.Count);

        var swap = list[pos1];
        list[pos1] = list[pos2];
        list[pos2] = swap;
      }
    }


  }
}
