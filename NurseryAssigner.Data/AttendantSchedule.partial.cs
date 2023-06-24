using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryAssigner.Data
{
  partial class AttendantSchedule
  {
    public string PostionName
    {
      get
      {
        return $"{Attendant.AgeGroup.Name}{(Position == 2 ? " " : "")}";
        //if (Position == 1)
        //  return "Adult";
        //else if (Position == 2)
        //  return "Older Kid";
        //else if (Position == 3)
        //  return "Younger Kid";
        //else
        //  return "Other";
      }
    }

    //public string DayDescription
    //{
    //  get
    //  {
    //    var result = Service.Date.ToShortDateString();
    //    var db = new NurseryAssignerEntities();
    //    var additional = db.AdditionalServices.ToList().FirstOrDefault(s => s.Date.ToShortDateString() == result);
    //    if (additional != null)
    //      result += "\r\n" + additional.Description;

    //    return result; 
    //  }
    //}
  }
}
