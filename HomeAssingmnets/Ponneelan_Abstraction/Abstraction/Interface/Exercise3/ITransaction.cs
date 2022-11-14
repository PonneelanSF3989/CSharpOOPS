using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public interface ITransaction
    {
        public int Amount { get; set; }
        
        public void Calculate();
        public  void Display();
    }
}