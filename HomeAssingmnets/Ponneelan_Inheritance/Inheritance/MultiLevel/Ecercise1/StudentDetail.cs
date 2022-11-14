using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecercise1
{
    public enum Standart {Default, Tenth,Twelth}
    public enum Branch {Default, A,B,c}
    public enum Degree{Default ,PG,UG}
    public enum Department {Default,EEE,ECE}
    public class StudentDetail : PersonDetails
    {
        
        public static int s_regiserNumber = 1000;
        public string RegisterNumber { get;  }
        public Standart StudentStandart { get; set; }
        public Branch StudentBranch { get; set; }
        public DateTime AcademicYear { get; set; }
        
        public StudentDetail(Standart standart , Branch branch, DateTime academicYear)
        {
            s_regiserNumber++;
            RegisterNumber = "SID" + s_regiserNumber;
            StudentStandart = standart;
            StudentBranch =branch;
            AcademicYear = academicYear;
        }

        public StudentDetail(){}
         public StudentDetail(string personId,string name,string fatherName, long phoneNumber, string mailID, DateTime dob, Gender gender,string studentID,Standart standart , Branch branch, DateTime academicYear) : base( personId, name, fatherName,  phoneNumber,  mailID,  dob,  gender)
        {
           
            RegisterNumber = studentID;
            StudentStandart = standart;
            StudentBranch =branch;
            AcademicYear = academicYear;
        }

        
        
        
        
        public  void ShowStudentInfo()
        {
           
                Console.WriteLine($"Register Number : {RegisterNumber}  ");
                ShowDetails();
                Console.WriteLine($"Standard : {StudentStandart}  Branch : {StudentBranch}  Academic Year  : {AcademicYear}");
        
        }
    }
}