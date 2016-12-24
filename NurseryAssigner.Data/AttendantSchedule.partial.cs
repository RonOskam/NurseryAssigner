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
          return "Adult/Middle School";
        else if (Position == 4)
          return "Middle School";
        else
          return "Elementary";
      }
    }

    public string DayDescription
    {
      get
      {
        var result = Service.Date.ToShortDateString();
        var db = new NurseryAssignerEntities();
        var additional = db.AdditionalServices.ToList().FirstOrDefault(s => s.Date.ToShortDateString() == result);
        if (additional != null)
          result += "\r\n" + additional.Description;

        return result; 
      }
    }
  }
}
