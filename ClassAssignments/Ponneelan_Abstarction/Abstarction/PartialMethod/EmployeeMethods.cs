using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialMethod
{
    public partial class Employee

    {
        public Employee(string name)
        {
            Id++;
            this.Name = name;
            ShowEmployeeId();
            

        }

        public void Display()
        {
            Console.WriteLine($"Employee Name {this.Name}");
        }
        
    }
}