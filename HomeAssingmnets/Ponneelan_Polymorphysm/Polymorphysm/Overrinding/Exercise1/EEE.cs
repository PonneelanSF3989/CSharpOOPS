using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class EEE : Library
    {
        public override string BookName  { get; set; }

       public override int  BookID { get; set; }

       public override string AuthorName { get; set; }
       
       public string DepartmentName { get; set; }
       
       
       
       
       
       


        public override void SetBookIfno()
        {
            DepartmentName = "EEE";
            BookName = "Java";
            BookID = 1111;
            AuthorName = "Balagurusami";
        }


       public override void Display()
       {
            System.Console.WriteLine("Department    "+DepartmentName);
            System.Console.WriteLine("Library ID    "+LibraryID);
            System.Console.WriteLine("Name      "+BookName);
            System.Console.WriteLine("BookID    "+BookID);
            System.Console.WriteLine("Author Name       "+AuthorName);

       }
    }
}