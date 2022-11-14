using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Department
    {
        public string DepartmentName { get; set; }

        public string Degree { get; set; }
        
        public Department(string departmentName,string degree)
        {
            DepartmentName  = departmentName;
            Degree = degree;
        }
        
        
        
    }
}