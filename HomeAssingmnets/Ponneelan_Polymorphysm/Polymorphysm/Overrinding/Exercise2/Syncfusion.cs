using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Syncfusion : FreeLancer
    {
       public string EmployeeID { get; set; }
       
       private static int s_EID = 1000;

       public string Location { get; set; }
       
       
        
        
        
        public Syncfusion(string name,string fatherName,int age,string roll,int slaray, int days,string location) : base(name,fatherName,age,roll,slaray,days)
        {
            s_EID++;
            EmployeeID = "SF"+s_EID;
            Location = location;
        }

        public override void  Calculate()
        {
            TotalTalary = WorkingDays * DaySalary;
        }
        
        public override void Display()
        {

            Console.WriteLine("Name     "+PersonName);
            Console.WriteLine("PersonID     "+PersonID);
            Console.WriteLine("Employee     "+EmployeeID);
            Console.WriteLine("Roll     "+Roll);
            Console.WriteLine("Salary   "+DaySalary);
        }
        
    }
}
