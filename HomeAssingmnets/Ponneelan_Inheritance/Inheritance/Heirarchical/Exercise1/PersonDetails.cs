using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public enum Gender {Detault,Male,Female}
    public class PersonDetails
    {
        private static int s_personID = 1000;
        public string PersonID { get; }
        
        
        public string PersonName { get; set; }
        
        public string FatherName { get; set; }
        
        public long  PhoneNumber { get; set; }
        
        public string Mail { get; set; }
        
        public DateTime DOB { get; set; }
        
        public Gender PersonGender { get; set; }
        
        public PersonDetails(){}
        public PersonDetails(string name,string fatherName, long phoneNumber, string mailID, DateTime dob, Gender gender)
        {
            s_personID++;
            PersonID = "PID" + s_personID;
            PersonName = name;
            FatherName = fatherName;
            PhoneNumber = phoneNumber;
            Mail = mailID;
            DOB = dob;
            PersonGender =gender;
        }
        public PersonDetails(string personId,string name,string fatherName, long phoneNumber, string mailID, DateTime dob, Gender gender)
        {
           
            PersonID = personId;
            PersonName = name;
            FatherName = fatherName;
            PhoneNumber = phoneNumber;
            Mail = mailID;
            DOB = dob;
            PersonGender =gender;
        } 

        public void ShowPersonsDetails()
        {
            Console.WriteLine($"PersonID : {PersonID}  Person Name : {PersonName}  Father Name : {FatherName}  Phone Number : {PhoneNumber}  Mail : {Mail}  Date of Birth : {DOB}  Gender : {PersonGender}");
        }

    }
}