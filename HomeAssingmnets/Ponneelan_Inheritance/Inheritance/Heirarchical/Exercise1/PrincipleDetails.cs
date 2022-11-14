using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class PrincipleDetails : PersonDetails
    {
        private static int s_pricipleID = 1000;

        public string PrincipleID { get;  }
        public string Qualification { get; set; }
        
        public int  Experience { get; set; }
        
        public DateTime DateOfJoining { get; set; }
        
        public PrincipleDetails(string qualification, int experience, DateTime doj)
        {
            s_pricipleID++;
            PrincipleID = "PID" + s_pricipleID;
            Qualification = qualification;
            Experience = experience;
            DateOfJoining = doj;

        }

        public PrincipleDetails(string personId,string name,string fatherName, long phoneNumber, string mailID, DateTime dob, Gender gender,string principleID,string qualification, int experience, DateTime doj):base( personId, name, fatherName,  phoneNumber,  mailID,  dob, gender)
        {
            PrincipleID =principleID;
            Qualification = qualification;
            Experience = experience;
            DateOfJoining = doj;
        }

        public void ShowPrincileDetails()
        {
            Console.WriteLine($"Principle ID : {PrincipleID}");
            ShowPersonsDetails();
            Console.WriteLine($"Qualification : {Qualification}  Experience : {Experience} Date of Joining {DateOfJoining}");
        }
        
        
    }
}