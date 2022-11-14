using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public enum Standart {Default, Tenth,Twelth}
    public enum Branch {Default, A,B,c}
    public class StudentDetails : PersonDetails
    {
        private static List<StudentDetails> studentData = new List<StudentDetails>();
        public static int s_regiserNumber = 1000;
        public string RegisterNumber { get;  }
        public Standart StudentStandart { get; set; }
        public Branch StudentBranch { get; set; }
        public DateTime AcademicYear { get; set; }
        
        public StudentDetails(string personId,string name,string fatherName, long phoneNumber, string mailID, DateTime dob, Gender gender,string studenID,Standart standart , Branch branch, DateTime academicYear) : base (personId,name, fatherName,  phoneNumber,  mailID, dob, gender)
        {
            
            RegisterNumber = studenID;
            StudentStandart = standart;
            StudentBranch = branch;
            AcademicYear = academicYear;
        } 
        public StudentDetails(Standart standart , Branch branch, DateTime academicYear): base()
        {
             s_regiserNumber++;
            RegisterNumber = "STU" + s_regiserNumber;
            StudentStandart = standart;
            StudentBranch = branch;
            AcademicYear = academicYear;
        }
        
        public  void ShowInfo()
        {
           
                Console.WriteLine($"Register Number : {RegisterNumber}  ");
                ShowDetails();
                Console.WriteLine($"Standard : {StudentStandart}  Branch : {StudentBranch}  Academic Year  : {AcademicYear}");
        
        }

        public  void Updatestudent()
        {
            // Console.WriteLine("Enter the Person ID");
            //  string personID = Console.ReadLine();
            //  Console.WriteLine("Enter the Name");
            //  string name = Console.ReadLine();
            //  Console.WriteLine("Enter the father name");
            //  string fatherName = Console.ReadLine();
            //  Console.WriteLine("Enter the mobile number");
            //  long mobileNumber  = long.Parse(Console.ReadLine());
            //  Console.WriteLine("enter the mail id");
            //  string mailID = Console.ReadLine();
            //  Console.WriteLine("enter the date of Birth");
            //  DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            //  Console.WriteLine("Enter the gender");
            //  Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            //  Console.WriteLine("enter the class");
            //  Standart standart = Enum.Parse<Standart>(Console.ReadLine());
            //  Console.WriteLine("enter the branch");
            //  Branch branch = Enum.Parse<Branch>(Console.ReadLine());
            //  Console.WriteLine("enter the academic year");
            //  DateTime academicYear = DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
            //  StudentDetails student = new StudentDetails(personID,name,fatherName,mobileNumber,mailID,dob,gender,standart,branch,academicYear);
            //  studentData.Add(student);
        }



    
        
        
        
        


        
        
        
    }
}