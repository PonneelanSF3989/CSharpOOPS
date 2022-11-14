using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class EmployeeDetails : PersonalDetails
    {
        public int EmpId { get; set; }

        public EmployeeDetails(string name, string motherName, string fatherName, long number, string mail, DateTime dob, string gender) : base(name, motherName, fatherName, number, mail, dob, gender) { }
        public override void StatusInfo()
        {
            System.Console.WriteLine("Name: " + Name);

            System.Console.WriteLine("Number: " + Number);
            System.Console.WriteLine("Mail: " + Mail);
            System.Console.WriteLine("DOB: " + DOB);
            System.Console.WriteLine("Gender: " + Gender);
        }
        // public override  void  UpdateInfo()
        // {
        //     System.Console.Write("Enter you name: ");
        //     Name = Console.ReadLine();
        //     System.Console.Write("Enter your Father Name: ");
        //     FatherName = Console.ReadLine();
        //     System.Console.Write("Enter Mail: ");
        //     Mail = Console.ReadLine();
        //     System.Console.Write("Enter DOB: ");
        //     DOB = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        //     System.Console.Write("Enter your gender: ");
        //     Gender = Console.ReadLine();
        //     System.Console.Write("Enter your Standard: ");
        // }
    }
}