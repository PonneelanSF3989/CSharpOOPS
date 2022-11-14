using System;
namespace Exercise2
{
    public sealed class PatientDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Number { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public PatientDetails(string name, string fatherName, long number, string mail, DateTime dob, string gender)
        {
            Name = name;
            FatherName = fatherName;
            Number = number;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
    }
}