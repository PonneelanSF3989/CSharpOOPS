using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Employee

    {
        public Employee(int id, string name)
        {
            this.Name = name;
            this.Id = id;

        }

        public void Display()
        {
            Console.WriteLine($"Employee ID {this.Id}   Employee Name {this.Name}");
        }
    }
}