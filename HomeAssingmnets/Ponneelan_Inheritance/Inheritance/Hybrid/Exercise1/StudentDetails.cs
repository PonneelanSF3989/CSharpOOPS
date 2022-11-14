using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class StudentDetails
    {
        private static int s_registerNumber;
        public string RegisterNumber { get; set; }
        
        public string PersonName { get; set; }
        
        public string FatherName { get; set; }
        
        public int Age { get; set; }
        public string Gender { get; set; }
        
        public long  PhoneNumber { get; set; }
        
        public DateTime DOB { get; set; }
        
        
        public StudentDetails(string name,string fatherName,int age,string gender,long  phoneNumber,DateTime dob)
        {
            s_registerNumber++;
            RegisterNumber = "SID"+s_registerNumber;
            PersonName = name;
            FatherName  = fatherName;
            Age = age;
            Gender  = gender;
            PhoneNumber = phoneNumber;
            DOB  = dob;
        }
    }
}