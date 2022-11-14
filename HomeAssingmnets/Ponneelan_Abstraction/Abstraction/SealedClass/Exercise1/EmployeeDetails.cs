using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public sealed class EmployeeDetails : PersonalDetails
    {
        public string UserId { get; set; }
        public string Password { get; set; }

        public override void UpdateInfo()
        {
            System.Console.WriteLine("Enter Your Name: ");
            Name = Console.ReadLine();
            System.Console.WriteLine("Enter Your Mail-Id");
            Mail = Console.ReadLine();

        }
    }

}