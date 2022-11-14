using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class AreaCalculator
    {
        
        public double radius = 4.0;
        public double area ;
        
       
       public virtual void Calculate()
       {
            area = (float)3.14 * (radius* radius);
           
       }

       public virtual void Display()
       {
        Console.WriteLine("Area     "+area);
       }
        
        
    }
}