using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Registration : PersonDetaisl ,IFamilyDetails ,IShowData
    {
        private int s_registerNumber = 1000;
        public string RegistrationNUmber { get; set; }
        
        public DateTime DateOfRegistration { get; set; }

        public string FatherName { get; set; }
    
        public string MotherName { get; set; }
        
        public string Homeaddres { get; set; }
        
        public int NumberOfSibilings { get; set; }

        public Registration(string name, DateTime dob,  int  age,string fatherName, string motherName,string address, int sibilingsCount,DateTime dor) : base(name,dob,age)
        {
            s_registerNumber++;
            RegistrationNUmber = "RID" + s_registerNumber;
            DateOfRegistration = dor;
            FatherName = fatherName;
            MotherName = motherName;
            Homeaddres = address;
            NumberOfSibilings = sibilingsCount;
        }

        public void ShowData()
        {
            Console.WriteLine(PersonName +"     "+RegistrationNUmber+"     "+Age+"     "+DOB+"     "+FatherName+"      "+MotherName+"      "+Homeaddres+"      "+NumberOfSibilings);
        }
        
        
    }
}