using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class BookDetails : RackDetails
    {
        public string BookName { get; set; }
        
        private static int s_bookID = 1000;
        public string BookID { get; set; }
        public string AuthorName { get; set; }
        
        public int Price { get; set; }

        public BookDetails(string departmentName,string degree,int rackNumber,int colunmNumber,string bookName,string authorName,int price) : base(departmentName,degree,rackNumber,colunmNumber)
        {
            s_bookID++;
            BookID = "BID"+s_bookID;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }
        public void Display()
        {
            Console.WriteLine(BookID+"  "+BookName+"    "+DepartmentName+"  "+Degree+"  "+RackNumber+"  "+ColunmNumber+"    "+AuthorName+"  "+Price);
        }
        
        
        
    }
}