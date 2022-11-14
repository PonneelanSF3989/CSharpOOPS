using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class PersonalDetails
    {

        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Number { get; set; }
        public string Mail { get; set; }
        public virtual void UpdateInfo()
        {
            System.Console.WriteLine("Enter Your number: ");
            Number = Console.ReadLine();

            System.Console.WriteLine("enter your mailid");
            Mail=Console.ReadLine();
            
        }
    }
}