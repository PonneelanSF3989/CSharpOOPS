using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public partial class Calculator
    {
        public void Addition()
        {
            System.Console.WriteLine("Addition: "+(Number1+Number2));
        }
        public void Subtraction()
        {
            System.Console.WriteLine("Subtraction: "+(Number1-Number2));
        }
    }
}