using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        
        public int Age { get; set; }
        public string Gender    { get; set; }
        public DateTime DOB { get; set; }
        
        public PersonalInfo(string name,int age,string gender, DateTime dob)
        {
            Name = name;
            Age = age;
            Gender = gender;
            DOB = dob;
            
        }
        
        
    }
}