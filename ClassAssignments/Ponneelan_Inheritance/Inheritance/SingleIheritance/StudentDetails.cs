using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Department {Default,ECE,EEE}
    public enum Year {Default,First,Second,Third,Fourth}
    public class StudentDetails : PersonalDetails 
    {
        private static int s_studentID = 1000;
        public string StudentID { get;  }
        public Department StudentDepartment {get; set; }
        public Year StudentYear { get; set; }
        
        
        public StudentDetails(string AID,string name,string fatherName,Gender gender, DateTime dob,Department department, Year year) : base( AID, name, fatherName, gender,dob)
        {
            s_studentID++;
            StudentID = "STU" + s_studentID;
            StudentDepartment = department;
            StudentYear = year;
        }

        public void ShowStudent ()
        {
            Console.WriteLine($"Student Id : {StudentID}  ");
            ShowDetails();
            Console.WriteLine($"DepartMent : {StudentDepartment}  Year : {StudentYear} ");
           
        }
        
        
        
    }
}