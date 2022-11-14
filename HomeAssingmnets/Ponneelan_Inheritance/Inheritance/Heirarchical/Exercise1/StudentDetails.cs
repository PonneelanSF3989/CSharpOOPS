using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public enum Degree{Default ,PG,UG}
    public enum Department {Default,EEE,ECE}
    public enum Year {Default,first,second,third,fourth}
    public class StudentDetails : PersonDetails
    {
        public static int s_regiserNumber = 1000;
        public string RegisterNumber { get;  }
        public Degree StudentDegree { get; set; }
        public Department StudentDepartment { get; set; }
        public DateTime Year { get; set; }
        
         public StudentDetails(Degree Degree , Department Department, DateTime academicYear) 
        {
            s_regiserNumber++;
            RegisterNumber = "STU" + s_regiserNumber;
            StudentDegree = Degree;
            StudentDepartment = Department;
            Year = academicYear;
        } 
        public StudentDetails(string personId,string name,string fatherName, long phoneNumber, string mailID, DateTime dob, Gender gender,string studentID,Degree Degree , Department Department, DateTime academicYear) : base (personId,name, fatherName,  phoneNumber,  mailID, dob, gender)
        {
           
            RegisterNumber =studentID;
            StudentDegree = Degree;
            StudentDepartment = Department;
            Year = academicYear;
        } 

        public void ShowStudentDetails()
        {
            Console.WriteLine($"Student ID {RegisterNumber}");
            ShowPersonsDetails();
            Console.WriteLine($"Department : {StudentDepartment}  Degree : {StudentDegree}  Academcic Year : {Year}");
        }
    }
}    