using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialMethod
{
    public partial class Employee
    {
      public string Name { get; set; }
      public static int Id = 1000;
      public  partial void ShowEmployeeId();


      

    }
}