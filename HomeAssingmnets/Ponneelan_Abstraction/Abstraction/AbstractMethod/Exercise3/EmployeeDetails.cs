using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class EmployeeDetails : FamilyDetails
    {
        public string Role { get; set; }
        
        public DateTime DOJ { get; set; }
        
        public EmployeeDetails(string name,string fatherName,int age,string gender,string motherName,string native,int noOfSibilings,string role,DateTime doj) : base( name, fatherName, age, gender, motherName, native, noOfSibilings)
        {
            Role = role;
            DOJ = doj;
        }
    }
}