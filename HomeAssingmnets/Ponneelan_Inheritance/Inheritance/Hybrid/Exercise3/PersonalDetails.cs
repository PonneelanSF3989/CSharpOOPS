using System;
namespace Exercise3
{
    public class PersonalDetails
    {
        private static int s_regId=1000;
        public string RegistrationId { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Number { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public PersonalDetails(string name, string fatherName, long number, DateTime dob, string gender)
        {
            Name = name;
            FatherName = fatherName;
            Number = number;
            DOB = dob;
            Gender = gender;
            s_regId++;
            RegistrationId="RID"+s_regId;
        }
    }
}