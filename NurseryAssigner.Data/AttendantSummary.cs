using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NurseryAssigner.Data
{
  public class AttendantSummary
  {
    public string GroupID { get; set; }
    public string Name { get; set; }
    public DateTime Day { get; set; }
    public string AMPM { get; set; }

    NurseryAssignerEntities _db;

    public AttendantSummary(NurseryAssignerEntities db)
    {
      _db = db;
    }

    public string SpecialDay
    {
      get
      {
        var special = _db.AdditionalServices.FirstOrDefault(s => s.Date == Day && s.AMPM == AMPM);
        return special?.Description;
      }
    }

    public static List<AttendantSummary> Load(NurseryAssignerEntities db, DateTime startDate, DateTime endDate)
    {
       var schedule = db.AttendantSchedules.Include("Attendant").Include("Service").Where(s => s.Service.Date >= startDate && s.Service.Date <= endDate).OrderBy(s => s.AttendantID).ToList()
        .Select(s => new AttendantSummary(db)
        {
          //HARD CODING ALERT!!  Have to manually put Boerman kids together because there are 2 families of them
          GroupID = (s.AttendantID == 179 || s.AttendantID == 192 ? "BoermanRS" : s.Attendant.LastName),
          Name = s.Attendant.FirstName + " " + s.Attendant.LastName,
          Day = s.Service.Date,
          AMPM = s.Service.AMPM
        }).ToList();

      return schedule;
    }
  }

}
