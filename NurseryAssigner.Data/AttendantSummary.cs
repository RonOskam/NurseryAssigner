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

    public string SpecialDay
    {
      get
      {
        var db = new NurseryAssignerEntities();
        var special = db.AdditionalServices.FirstOrDefault(s => s.Date == Day && s.AMPM == AMPM);
        return special?.Description;
      }
    }

    public static List<AttendantSummary> Load(DateTime startDate, DateTime endDate)
    {
      var db = new NurseryAssignerEntities();

      var schedule = db.AttendantSchedules.Include("Attendant").Include("Service").Where(s => s.Service.Date >= startDate && s.Service.Date <= endDate).OrderBy(s => s.AttendantID).ToList()
        .Select(s => new AttendantSummary
        {
          GroupID = (s.AttendantID == 179 ? "BoermanM" : s.Attendant.LastName),
          Name = s.Attendant.FirstName + " " + s.Attendant.LastName,
          Day = s.Service.Date,
          AMPM = s.Service.AMPM
        }).ToList();

      return schedule;
    }
  }

}
