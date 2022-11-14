using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Attendance:StudentDetails
    {
        public int DaysWorked { get; set; }
        public int NumberOfLeaves { get; set; }
        public int NumberOfPermission { get; set; }
        public int totalSalary { get; set; }
        public Attendance(){}

        public Attendance(int daysWorked,int noOfLeaves,int noOfPermission)
        {
            DaysWorked=daysWorked;
            NumberOfLeaves=noOfLeaves;
            NumberOfPermission=noOfPermission;
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            System.Console.WriteLine("Days Worked: "+DaysWorked);
            System.Console.WriteLine("Number of Leaves: "+NumberOfLeaves);
            System.Console.WriteLine("Number of Permission: "+NumberOfPermission);
        }
        public int  TotalSalary()
        {
            totalSalary = (DaysWorked*500)-(NumberOfLeaves*500)+(NumberOfPermission*500);
            return totalSalary;
        }

        public static Attendance operator +(Attendance month1,Attendance month2)
        {
            Attendance TotalMonth = new Attendance();
            TotalMonth.DaysWorked=month1.DaysWorked+month2.DaysWorked;            
            TotalMonth.NumberOfLeaves=month1.NumberOfLeaves+month2.NumberOfLeaves;
            TotalMonth.NumberOfPermission=month1.NumberOfPermission+month2.NumberOfPermission;
            return TotalMonth;
        }
    }
}