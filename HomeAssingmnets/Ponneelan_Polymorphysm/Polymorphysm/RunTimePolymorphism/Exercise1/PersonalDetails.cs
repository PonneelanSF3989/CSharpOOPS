using System;
namespace Exercise1
{
    public enum Gender { Default, Male, Female, transgender }
    public abstract class PersonalDetails
    {
        private static int s_aId = 1000;
        public string PersonID { get; }
        public string PersonName { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }

        public abstract void ShowDetails();
    }
}
