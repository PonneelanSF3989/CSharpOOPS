using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Employee : Display
    {
        public string EmployeeName { get; set; }
        
        public string EmployeeId { get; set; }
        
        public string FatherName { get; set; }
        
        public void Display1()
        {
            Console.WriteLine(EmployeeName +"   "+EmployeeId +"     "+FatherName);
        }
        
    }
}