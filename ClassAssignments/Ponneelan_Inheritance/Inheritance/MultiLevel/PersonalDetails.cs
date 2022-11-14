using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel
{
    public enum Gender {Default, male,female}
    public class PersonalDetails
    {
        private static int s_aid = 1000;
        public string AID { get;  }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender PersonGender { get; set; }
        public DateTime DOB { get; set; }
        
        // public PersonalDetails()
        // {

        // }
        public PersonalDetails(string name, string fatherName,Gender gender,DateTime dob)
        {
            s_aid++;
            AID = "AD" +  s_aid;
            Name = name;
            FatherName = fatherName;
            PersonGender = gender;
            DOB = dob;
        }
         public PersonalDetails(string aid,string name, string fatherName,Gender gender,DateTime dob)
        {
            AID = aid;
            Name = name;
            FatherName = fatherName;
            PersonGender = gender;
            DOB = dob;
        }
        public void  ShowDetails()
        {
            Console.WriteLine($"ID : {AID}  Name : {Name} Father Name : {FatherName} Gender : {PersonGender} DateOf Birth : {DOB}");
        }
        
        

    }
}