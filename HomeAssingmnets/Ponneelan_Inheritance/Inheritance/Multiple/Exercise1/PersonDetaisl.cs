using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1 
{
    public class PersonDetaisl : IShowData
    {
        private static int s_personID;
        public string PersonID { get; set; }
        
        
        public string PersonName { get; set; }
        
        public DateTime DOB { get; set; }
        
        public int Age { get; set; }

        public PersonDetaisl(string name,DateTime dob,int age) 
        {
            s_personID++;
            PersonID = "PID"+ s_personID;
            PersonName = name;
            DOB = dob;
            Age = age;
        }
        
        public void ShowData()
        {
            Console.WriteLine(PersonID+"    "+PersonName+"      "+DOB+"     "+Age);
        }
        
    }
}