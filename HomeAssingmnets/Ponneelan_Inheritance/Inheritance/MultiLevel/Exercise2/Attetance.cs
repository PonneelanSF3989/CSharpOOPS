using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Attetance : PersonDetails
    {
        public DateTime Date { get; private set; }
        
        public int WorkedHours { get; set; }
        
        public Attetance(string personId,string name,string fatherName, long phoneNumber, string mailID, DateTime dob, Gender gender,DateTime date,int workedHours) : base( personId, name, fatherName,  phoneNumber,  mailID,  dob, gender)
        {
            Date = date;
            WorkedHours = workedHours;
        }

        public void ShowAttentanceDetail()
        {
            ShowDetails();
            Console.WriteLine(Date+"    "+WorkedHours);
        }
    }
}