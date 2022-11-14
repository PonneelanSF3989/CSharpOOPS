using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public  class PersonDetails
    {
        private static int s_PID;
        public  string PersonID { get; set; }
        
        public string PersonName { get; set; }
        
        public string FatherName { get; set; }
        
        public int Age { get; set; }

        public PersonDetails(string name,string fatherName,int age)
        {
            s_PID++;
            PersonID = "PID" + s_PID;
            PersonName = name;
            FatherName = fatherName;
            Age = age;
        }
        
        
        
    }
}