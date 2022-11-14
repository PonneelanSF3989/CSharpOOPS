using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerise1
{
    public abstract class Shape
    {
        
        public abstract double  Area { get; set; }

        protected double area;
        protected double volume;
        public abstract double  Volume { get; set; }

        public double  Height{get;set;} 
        public double Width { get; set; }
        
        public double Radius { get; set; }
        

        public abstract void Calculate();
        public abstract void Display();
       
        
        
        
        
        
    }
}