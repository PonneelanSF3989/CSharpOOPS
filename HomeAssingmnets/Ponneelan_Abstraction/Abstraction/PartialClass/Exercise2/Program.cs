using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentDetails student = new StudentDetails("Madhu","Mithan",9898989898,"Mith.com",new DateTime(2000,01,01),"Male");
            student.DisplayInfo();
        }
    }
}