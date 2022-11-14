using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public abstract class Library
    {
        public string SerialNumber { get; set; }

        public abstract string Name { get; set; }
        public abstract string Author   { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract int Year { get; set; }
        
        
        public abstract void SetBook();
        public abstract void Display();
        
        
        
        
         
    }
}