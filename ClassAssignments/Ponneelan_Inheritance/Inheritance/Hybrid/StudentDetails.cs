using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid
{
    public enum Department {Default,ECE,EEE}
    public enum Year {Default,First,Second,Third,Fourth}
    public class StudentDetails : PersonalDetails ,IMarkDetails
    {
        public Double  CGPA { get; set; }
        
        
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

        public StudentDetails(string AID,string name,string fatherName,Gender gender,string studentID, DateTime dob,Department department ) : base( AID, name, fatherName, gender,dob)
        {
            
            StudentID = studentID;
            StudentDepartment = department;
           
        }
        public void GetMarkDetails(Double cgpa)
        {
            CGPA = cgpa;
        }
        public void ShowStudent ()
        {
            Console.WriteLine($"Student Id : {StudentID}  ");
            ShowDetails();
            Console.WriteLine($"DepartMent : {StudentDepartment}  Year : {StudentYear} ");
            Console.WriteLine($"CGPA : {CGPA}");
           
        }
        
        
        
    }
}