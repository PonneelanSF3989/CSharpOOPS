using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialMethod
{
    public partial class Employee
    {
        public partial void ShowEmployeeId()
        {
            Console.WriteLine($"Employye Id {Id}");
        }
    }
}