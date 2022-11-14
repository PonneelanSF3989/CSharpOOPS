using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class TheoryExam:PersonalDetails
    {
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public int Mark4 { get; set; }

        public TheoryExam(string name, string fatherName, long number, DateTime dob, string gender,int mark1,int mark2,int mark3,int mark4):base( name,  fatherName,  number,  dob,  gender)
        {
            Mark1=mark1;
            Mark2=mark2;
            Mark3=mark3;
            Mark4=mark4;
        }
    }
}