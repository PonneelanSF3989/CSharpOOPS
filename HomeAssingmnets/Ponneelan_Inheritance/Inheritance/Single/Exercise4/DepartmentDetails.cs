using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerxise4
{
    public class DepartmentDetails
    {
        public string Degree { get; set; }
        public string DepartmentName { get; set; }
        

        public DepartmentDetails(string name,string degree)
        {
            Degree = degree;
            DepartmentName = name;
        }


        public void ShowDepartmentDetails()
        {
            Console.WriteLine($"Department Name  : {DepartmentName}   Degrre : {Degree} ");
        }
        
        
        
    }
}