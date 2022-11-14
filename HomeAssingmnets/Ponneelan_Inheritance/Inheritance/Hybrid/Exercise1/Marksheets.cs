using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Marksheets : TheoryExam,ICalculate
    {
        private static int s_markSheetNumber = 1000;
        public int  Total { get; set; }
        
        public double  Percentage { get; set; }
        public string MarkSheeetNumber { get; set; }
        
        public DateTime DateOfIssuie { get; set; }
        
        

        public void Calculate(int[] sem1,int[] sem2,int[] sem3, int[] sem4)
        {
            Total += sem1.Sum();
            Total += sem2.Sum();
            Total += sem3.Sum();
            Total += sem4.Sum();
            Total /= 4;

            Percentage = (double)(Total/2400) * 100;

        }


        public Marksheets(string name,string fatherName,int age,string gender,long mobileNUmber,DateTime dob,int[] mark1,int[] mark2,int[] mark3,int[] mark4,DateTime doi): base(name,fatherName,age,gender,mobileNUmber,dob,mark1,mark2,mark3,mark4)
        {
            s_markSheetNumber++;
            MarkSheeetNumber = "MID" + s_markSheetNumber;

            DateOfIssuie = doi;
        }

        public void ShoeMarkSheet()
        
        {
            Calculate(Sem1,Sem2,Sem3,Sem4);
            Console.WriteLine(MarkSheeetNumber+"    "+PersonName+"      "+FatherName+"      "+Age+"     "+Gender+"     "+PhoneNumber+"     "+"     "+DOB+"      "+Total+"       "+Percentage);
        }
        
        
    }
}