using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class SalaryDetails : Attetance
    {
        public int Salary { get; set; }
        
        public string Month { get; set; }
        
        public SalaryDetails(string personId,string name,string fatherName, long phoneNumber, string mailID, DateTime dob, Gender gender,DateTime date,int workedHours,string month,int salary) :base( personId, name, fatherName,  phoneNumber,  mailID,  dob,  gender, date, workedHours)
        {
            Salary =salary;
            Month = month;
        }
        public void ShowSalaryDetails()
        {
            ShowAttentanceDetail();
            Console.WriteLine(Salary +"     "+Month);
        }
    }
}