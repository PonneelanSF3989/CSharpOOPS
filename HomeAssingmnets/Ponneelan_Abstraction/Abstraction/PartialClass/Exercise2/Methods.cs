using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2

{
    public partial class StudentDetails
    {
        public void DisplayInfo()
        {
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("Fathers name: "+FatherName);
            System.Console.WriteLine("DOB: "+DOB);
            System.Console.WriteLine("Number: "+Number);
            System.Console.WriteLine("Mail: "+Mail);
        }
    }
}