using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class CSE : Library
    {
        public override string Name { get; set; }
        public override string Author { get; set; }
        
        public override string BookName { get; set; }
        
        public override string PublisherName { get; set; }
        
        public override int Year { get; set; }
        
        public override void SetBook()
        {
            Name = "Python";
            Author = "Deva";
            BookName = "Complete reference";
            PublisherName = "jetberines";
            Year = 1999;
        }

        public override void Display()
        {
            SetBook();
            Console.WriteLine("CSE Department");
            Console.WriteLine(Name+"    "+Author+"  "+BookName+"    "+PublisherName+"   " +Year+"   ");

        }
    }
}