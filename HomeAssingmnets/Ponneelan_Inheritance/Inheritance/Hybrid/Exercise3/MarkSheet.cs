using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class MarkSheet : TheoryExam, FamiliDetails
    {
        private static int s_markSheetNumber = 100;
        public string MarkSheetNumber { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }
        public int ProjectMark { get; set; }
        public MarkSheet(string name, string fatherName, long number, DateTime dob, string gender, int mark1, int mark2, int mark3, int mark4) : base(name, fatherName, number, dob, gender, mark1, mark2, mark3, mark4)
        {
            s_markSheetNumber++;
            MarkSheetNumber="MS"+s_markSheetNumber;
        }
        public void CalculateUG(){
            System.Console.WriteLine("Total: "+(Mark1+Mark2+Mark3+Mark4));
            System.Console.WriteLine("Percentage: "+(Mark1+Mark2+Mark3+Mark4)/4);
        }
        public void ShowMarkSheet()
        {
            System.Console.WriteLine("MarksheetNumber: "+MarkSheetNumber);
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("Father Name: "+FatherName);
            System.Console.WriteLine("Gender: "+Gender);
            System.Console.WriteLine("Total: "+(Mark1+Mark2+Mark3+Mark4));
            System.Console.WriteLine("Percentage: "+(Mark1+Mark2+Mark3+Mark4)/4);
        }
    }
}