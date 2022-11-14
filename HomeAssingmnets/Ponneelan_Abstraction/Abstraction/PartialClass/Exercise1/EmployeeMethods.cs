using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public partial class Properties
    {
        public void Display()
        {
            System.Console.WriteLine("Name : "+Name);
            System.Console.WriteLine("Gender : "+Gender);
            System.Console.WriteLine("Mobile Number : "+Number);
            System.Console.WriteLine(" ");
        }
        public void Update()
        {

            System.Console.WriteLine("Enter  Name: ");
            Name=Console.ReadLine();
            System.Console.WriteLine("Enter Gender: ");
            Gender=Console.ReadLine();
            System.Console.WriteLine("Enter Number: ");
            Number=Console.ReadLine();
            
        }
    }
}