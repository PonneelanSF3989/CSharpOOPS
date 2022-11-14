using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class TeachersDetails  : PersonDetails
    {
        private static int s_teacherID =1000;
        public string TeacherID { get; set; }
        
        
        public Department DepartmentName { get; set; }
        
        public string Subject { get; set; }
        
        public string Qualification { get; set; }
        
        public int  Experience { get; set; }
        
        public DateTime DateOfJoining { get; set; }
        
        public TeachersDetails (Department department, string subject, string qualification,int experience,DateTime doj) : base()
        {
            s_teacherID++;
            TeacherID ="TID" + subject;
            DepartmentName = department;
            Subject = subject;
            Qualification =qualification;
            Experience = experience;
            DateOfJoining = doj;
        }
        public TeachersDetails (string personId,string name,string fatherName, long phoneNumber, string mailID, DateTime dob, Gender gender,string teacherID,Department department, string subject, string qualification,int experience,DateTime doj) :base( personId, name, fatherName,  phoneNumber,  mailID,  dob,gender)
        {
            TeacherID = teacherID;
            DepartmentName = department;
            Subject = subject;
            Qualification =qualification;
            Experience = experience;
            DateOfJoining = doj;
        }

        public void ShowTeachersDetails()
        {
            Console.WriteLine($"Teaxher Id : {TeacherID}");
            ShowPersonsDetails();
            Console.WriteLine($"Department : {DepartmentName}  Subject Taken : {Subject}  Qualification : {Qualification}  Experience : {Experience}  Date of Joining : {DateOfJoining}");
        }
    }
}