using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Syncfussion : Employee
    {
      
        public override string Name { get{return name;} set{name = value;} }

        public override void Salary(int days)
        {
            Display();
            Amount = (Double) days * 500;
            Console.WriteLine(Amount);
        }
        
        
    }
}