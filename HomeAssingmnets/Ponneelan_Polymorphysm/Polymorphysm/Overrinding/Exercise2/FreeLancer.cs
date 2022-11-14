using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class FreeLancer : PersonDetails
    {
        public string Roll { get; set; }
        public int  DaySalary { get; set; }
        public int  WorkingDays { get; set; }
        public int  TotalTalary { get; set; }
        
        
        
        public FreeLancer(string name,string fatherName,int age,string roll,int slaray, int days) : base(name,fatherName,age)
        {
            Roll = roll;
            DaySalary = slaray;
            WorkingDays = days;

        }

        public virtual void  Calculate()
        {
            TotalTalary = WorkingDays * DaySalary;
        }
        
        public virtual void Display()
        {
            Console.WriteLine("Name     "+PersonName);
            Console.WriteLine("PersonID     "+PersonID);
            Console.WriteLine("Roll     "+Roll);
            Console.WriteLine("Salary   "+DaySalary);
        }
        
        
    }
}