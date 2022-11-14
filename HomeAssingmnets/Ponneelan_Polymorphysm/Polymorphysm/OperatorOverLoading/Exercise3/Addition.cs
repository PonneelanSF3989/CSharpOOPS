using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Addition
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Result { get; set; }

        public Addition(int num1,int num2)
        {
            Number1=num1;
            Number2=num2;
        }
        public Addition(){}

        public void Add()
        {
            Result=Number1+Number2;
               
        }
        public static Addition operator +(Addition num1,Addition num2)
        {
            Addition num = new Addition();
            num.Number1=num1.Number1+num2.Number1;
            num.Number2=num1.Number2+num2.Number2;
            return(num);
        }
    }
}