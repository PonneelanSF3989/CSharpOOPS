using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerxise4
{
    public class BookInfo : DepartmentDetails
    {
        public string BookId  { get; set; }
        
        public string BookName { get; set; }
        
        public string AuthorName { get; set; }
        
        public int Price { get; set; }

        public BookInfo(string name,string degree,string bookid , string bookname, string authorname, int price) : base(name,degree)
        {

            BookId = bookid;
            BookName = bookname;
            AuthorName =authorname;
            Price = price;

        }


        public void Display()
        {
            Console.WriteLine(BookId);
            ShowDepartmentDetails();
            Console.WriteLine($"Book name  : {BookName}   Author name : {AuthorName}  Price {Price}");
        }
        
        
    }
}