using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid
{
    public class EmploymentDetails : StudentDetails
    {
        private static int s_employeeId = 1000;
        public string EmplyeeID { get;  }
        public DateTime DateOfJoining { get; set; }
        
        public EmploymentDetails(string AID,string name,string fatherName,Gender gender, DateTime dob,string studentID,Department department,DateTime doj) : base (AID,name,fatherName,gender,studentID,dob,department)
        {
            s_employeeId++;
            EmplyeeID = "EID"+s_employeeId;
            DateOfJoining = doj;
        }
        public void ShowEmployyeDetails ()
        {
            Console.WriteLine($"Employye Id : {EmplyeeID}  ");
            ShowStudent();
            Console.WriteLine($"Date Of joining : {DateOfJoining}   ");
           
        }
        
        
    }
}