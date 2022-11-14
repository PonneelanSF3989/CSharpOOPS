using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class SalaryInfo
    {
        public int SalaryofTheMonth { get; set; }
        
        public string Month { get; set; }
        
        public SalaryInfo(int salary,string month)
        {
            SalaryofTheMonth = salary;
            Month = month;
        }

        public void ShowSalary()
        {
            Console.WriteLine(SalaryofTheMonth +"   "+Month);
        }
        
    }
}