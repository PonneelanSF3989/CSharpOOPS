using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Application : IHSCMark,IPGMarks
    
    {

        private static int s_appiliactionID =1000;
        public string ApplicationID { get; set; }
        
       // public string ApplicationSatus { get; set; }
        
        
        
        private static int s_markSheeyID = 1000;
        public string PersonName { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        
        public DateTime DOB      { get; set; }
        public int Age { get; set; }
        
        
        public int PGTotal { get; set; }
        public int HSCTotal { get; set; }
        
        
        
        public double PGPercentage { get; set; }
        public double HSCPercentage { get; set; }
        
        
        public int  PhysicsMark { get; set; }
        
        public int  MathMarks { get; set; }
        
        public int  ChemistryMark { get; set; }
        public string MarkSheetNumber { get; set; }

        public int  Sem1 { get; set; }
        public int Sem2 { get; set; }
        
        public int Sem3 { get; set; }
        public int  Sem4 { get; set; }
        
        
        public Application(string name, string fatherName,int age,string gender, DateTime dob,int phyMark,int cheMark,int mathMark,int sem1, int sem2, int sem3,int sem4)
        {
            s_appiliactionID ++;
            ApplicationID = "AID"+s_appiliactionID;
            s_markSheeyID++;
            MarkSheetNumber = "HSCID" + s_markSheeyID;
            PersonName = name;
            FatherName = fatherName;
            Age = age;
            Gender = gender;
            DOB = dob;
            PhysicsMark = phyMark;
            ChemistryMark = cheMark;
            MathMarks = mathMark;
             Sem1 = sem1;
            Sem2 = sem2;
            Sem3 = sem3;
            Sem4 = sem4;

        }
       
        
        

        public void ShowMarkSheet()
        {
            Calculate();
            Console.WriteLine(MarkSheetNumber +"    "+PersonName +"     "+PGTotal+"       "+PGPercentage+"      "+HSCTotal+"        "+HSCPercentage);
        }

        public void Calculate()
        {

            PGTotal = Sem1+Sem2+Sem3+Sem4;
            PGPercentage = ((double)PGTotal/400) * 100;

            HSCTotal = PhysicsMark + MathMarks + ChemistryMark;
            HSCPercentage  =  ((double)HSCTotal / 300) * 100;

           
        }

        
        
        
        


    }
}