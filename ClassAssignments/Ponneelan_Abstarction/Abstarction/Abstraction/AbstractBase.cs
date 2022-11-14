using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Employee
    {
        protected string name;

        public abstract string Name { get  ; set; }

        public double Amount {get;set;}

        public void Display()
        {
            Console.WriteLine(name);
        }
        public abstract void  Salary (int days);
        
    }
}