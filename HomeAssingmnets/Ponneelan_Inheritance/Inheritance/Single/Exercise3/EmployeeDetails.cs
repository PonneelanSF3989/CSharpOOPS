using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Employee : SalaryInfo
    {
        public string EmployeeID { get; set; }
        
        public string EmployeeName { get; set; }
        
        public string Type { get; set; }
        
        public int  Bacic { get; set; }
        
        public int TotalSalary{ get; set; }


        public Employee (int basic,string month,string empId,string name, string type,int basicSalary,int totalTasalry) :base(basic ,month)
        {
        EmployeeID = empId;
        EmployeeName = name;
        Type = type;
        Bacic = basic;
        TotalSalary = totalTasalry;
        }

        public void ShowDetails()
        {
            Console.WriteLine(EmployeeID+"  "+EmployeeName+"    "+Type+"    "+TotalSalary+"     "+Bacic);
            ShowSalary();
        }

        
         
    }
}