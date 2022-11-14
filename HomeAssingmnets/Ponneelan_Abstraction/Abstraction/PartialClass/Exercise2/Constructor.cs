using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public partial class StudentDetails
    {
        public StudentDetails(string name, string fatherName, long number, string mail, DateTime dob, string gender)
        {
            this.Name = name;
            FatherName = fatherName;
            Number = number;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
    }
}