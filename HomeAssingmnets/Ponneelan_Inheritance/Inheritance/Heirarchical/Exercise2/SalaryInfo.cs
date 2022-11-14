using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class SalaryInfo
    {
        public int  BasicSalary { get; set; }
        
        public string Month { get; set; }

        public SalaryInfo(int basicSalary,string month)
        {
            BasicSalary  = basicSalary;
            Month = month;
        }
        public void  ShowSalary()
        {
            Console.WriteLine(BasicSalary +" "+ Month);
        }
        
    }
}