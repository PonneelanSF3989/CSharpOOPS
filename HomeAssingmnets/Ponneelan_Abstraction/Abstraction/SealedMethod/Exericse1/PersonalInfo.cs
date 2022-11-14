using System;
namespace Exercise1
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Number { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public PersonalInfo(string name, string fatherName, long number, string mail, DateTime dob, string gender)
        {
            Name = name;
            FatherName = fatherName;
            Number = number;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
        public virtual void StatusInfo()
        {
            //dispalay the studetn details
            System.Console.WriteLine("Name: " + Name);
            System.Console.WriteLine("Father Name: " + FatherName);
            System.Console.WriteLine("Number: " + Number);
            System.Console.WriteLine("Mail: " + Mail);
            System.Console.WriteLine("DOB: " + DOB);
            System.Console.WriteLine("Gender: " + Gender);
        }
        public virtual void  UpdateInfo()
        {
            //getting input from user
            System.Console.Write("Enter you name: ");
            Name = Console.ReadLine();

            System.Console.Write("Enter your Father Name: ");
            FatherName = Console.ReadLine();

            System.Console.Write("Enter Mail: ");
            Mail = Console.ReadLine();

            System.Console.Write("Enter DOB: ");
            DOB = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            System.Console.Write("Enter your gender: ");
            Gender = Console.ReadLine();

        }
    }
}