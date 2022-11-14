using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public interface ICalculate
    {
        public void Deposite(int amount);
        public void Withdraw(int amount);
        public void CheckBalance ();
    }
}