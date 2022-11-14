using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class CSE : Library
    {
       
       public override string BookName  { get; set; }

       public override int  BookID { get; set; }

       public override string AuthorName { get; set; }
       
      public string DepartmentName { get; set; }
      
      
       public CSE()
       {}
       
       


        public override void SetBookIfno()
        {
            DepartmentName = "CSE";
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