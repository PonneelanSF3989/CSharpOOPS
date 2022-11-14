using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class FamilyDetails : PersonDetails
    {
        public string MotherName { get; set; }
        
        public string LivingPalce { get; set; }
        
        public int NoOfSobolings { get; set; }
        
        public FamilyDetails(string name,string fatherName,int age,string gender,string motherName,string native,int noOfSibilings):base( name, fatherName, age, gender)
        {
            MotherName  =motherName;
            LivingPalce = native;
            NoOfSobolings = noOfSibilings;
        }

        public override void Display()
        {
            
            Console.WriteLine(MotherName+"  "+LivingPalce+"     "+NoOfSobolings);
        }
    }
}