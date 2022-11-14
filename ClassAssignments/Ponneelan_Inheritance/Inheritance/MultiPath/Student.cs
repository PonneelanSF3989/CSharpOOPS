using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiPath
{
    public class Student :IStudent,ISport,IAcademic
    {
        public string StudentName { get;  set; }
        public int SportMark { get; set; }
        public int  AcademicMark { get; set; }

        private static  int s_studentId = 1000;
        public string StudentID { get; set; }
        
        
        public Student()
        {
            s_studentId++;
            StudentID = "SID" + s_studentId;
        }

       public Student(string studentName, int sportsMark,int academicMark,string studentID)
       {
            StudentName = studentName;
            SportMark = sportsMark;
            AcademicMark = academicMark;
            StudentID  = studentID;
       }

       public void Display()
       {
        Console.WriteLine($"Student ID {StudentID}  Student Name : {StudentName}  Student Sports Mark {SportMark}   Academic Mark {AcademicMark}  ");
       }
        
        
        
        
        
        
    }
}