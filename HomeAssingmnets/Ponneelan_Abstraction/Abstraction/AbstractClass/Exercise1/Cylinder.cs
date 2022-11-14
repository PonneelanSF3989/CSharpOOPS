using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerise1
{
    public class Cylinder : Shape
    {
        public  override  double Area { get{return area;}set {area = value;}}
    
        
        public  override double Volume{get{return volume;} set {volume = value;}}
        public override void Calculate()
        {
            Area = 2 * 3.14 *Radius *(Radius + Height);
            volume = 3.14 * (Radius * Radius) * Height;
        }
        public override void Display()
        {
            Calculate();
            Console.WriteLine("Volume of Cylynder :     "+Volume);
            Console.WriteLine("Area of the cylynder :   "+Area);
            
        }
    }
}