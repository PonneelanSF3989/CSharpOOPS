using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecercise1
{
    public class HscMarkDetails : StudentDetail
    {
        private static int s_hscMarksheetNumber = 1000;
        public string  HSCMarksheetNumber{ get;  }
        public int  MathMark { get; set; }
        public int  ChemistryMark { get; set; }
        public int  PhysicsMark { get; set; }

        public int  TotalMark { get; set; }
        public Double PercentageOfMark { get; set; }

       public HscMarkDetails(int mathMark,int chemistryMark,int physicsMark)
       {
            s_hscMarksheetNumber++;
            HSCMarksheetNumber = "SID" + s_hscMarksheetNumber;
            MathMark = mathMark;
            ChemistryMark = chemistryMark;
            PhysicsMark = physicsMark;
            TotalMark = mathMark+chemistryMark+physicsMark;
            PercentageOfMark = (TotalMark/300) * 100;
       }

       public HscMarkDetails(string personId,string name,string fatherName, long phoneNumber, string mailID, DateTime dob, Gender gender,string studentID,Standart standart , Branch branch, DateTime academicYear,string hscMarkCheetNumber,int mathMark,int chemistryMark,int physicsMark) : base( personId, name, fatherName,  phoneNumber,  mailID,  dob,  gender, studentID, standart ,  branch,  academicYear)
       {
           
            HSCMarksheetNumber = hscMarkCheetNumber;
            MathMark = mathMark;
            ChemistryMark = chemistryMark;
            PhysicsMark = physicsMark;
            TotalMark = mathMark+chemistryMark+physicsMark;
            PercentageOfMark = (TotalMark/300) * 100;
       }

       public void ShowHcsDetailss()
       {
        Console.WriteLine($"MarkSheet Id : {HSCMarksheetNumber}");
        ShowStudentInfo();
        Console.WriteLine($"Math mark : {MathMark}   Physics Marks : {PhysicsMark} chemistry mark : {ChemistryMark}   ToTalMark : {TotalMark}  Percentage of Mark : {PercentageOfMark}");
       }
        
        
        
        
    }
}