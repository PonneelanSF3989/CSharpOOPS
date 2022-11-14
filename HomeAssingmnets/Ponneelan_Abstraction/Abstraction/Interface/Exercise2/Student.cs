using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{ 
    public class Student : Display
    {
        public string Name { get; set; }
        
        public string StudentID { get; set; }
        
        public string FatherName { get;  set; }
        
       public  void Display1()
        {
            Console.WriteLine(Name +"   "+StudentID+"   "+FatherName);
        }
        
    }
}