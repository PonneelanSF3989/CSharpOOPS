using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerise1
{
    public class Cubes : Shape
    {
        public  override  double Area { get{return area;}set {area = value;}}
    
        
        public  override double Volume{get{return volume;} set {volume = value;}}

        public double a { get; set; }
        
        
        public override void Calculate()
        {
            Area = 6 *(a*a);
            volume = a*a*a;
        }
        public override void Display()
        {
            Calculate();
            Console.WriteLine("Volume of Cube :     "+Volume);
            Console.WriteLine("Area of the Cube :   "+Area);
            
        }
    }
}