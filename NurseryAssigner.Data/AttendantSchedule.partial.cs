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
        if (Position == 1)
          return "First Adult";
        else if (Position == 2)
          return "Second Adult/HS";
        else if (Position == 3)
          return "5th to 8th Grade";
        else if (Position == 4)
          return "3rd/4th Grade";
        else
          return "Other";
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
