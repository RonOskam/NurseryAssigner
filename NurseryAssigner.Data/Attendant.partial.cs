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
  }
}
