using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class CircleCalculator:Calculator
    {
        public int Radius { get; set; }
        public sealed override void Area()
        {
            System.Console.WriteLine(Area);
        }
    }
}