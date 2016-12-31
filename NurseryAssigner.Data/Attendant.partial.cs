using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryAssigner.Data
{
  partial class Attendant
  {
    public string FullName
    {
      get
      {
        return FirstName + " " + LastName;
      }
    }

    public string LastFirst
    {
      get
      {
        return LastName + ", " + FirstName;
      }
    }

    public static long MaxAttendantsPerDay(NurseryAssignerEntities db)
    {
        long count = db.AssignmentCounts.GroupBy(c => c.AMPM).Select(g => g.Sum(v => v.Amount)).Max();
        return Convert.ToInt32(count);  
    }

  }
}
