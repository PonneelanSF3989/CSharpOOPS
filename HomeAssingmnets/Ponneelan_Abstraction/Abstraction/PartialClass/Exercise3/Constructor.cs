using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public partial class Calculator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public Calculator(int num1,int num2)
        {
            Number1=num1;
            Number2=num2;
        }
    }
}