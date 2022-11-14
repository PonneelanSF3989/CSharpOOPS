using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class VolumeCalculator : AreaCalculator
    {
        private int height = 10;
        public double volume;



    public override void Calculate()
    {
    
        volume = area * (float)height;     
    }


     public override void Display()
    {
        Console.WriteLine("Volume   "+ volume);
    }
    }
   

    
}