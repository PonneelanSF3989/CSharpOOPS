using System;
namespace Exercise3;
class  Program
{
    public static void Main(string[] args)
    {
        BookDetails newBook1 = new BookDetails("CSE","BE",10,4,"java","bala",1000);
        BookDetails newBook2 = new BookDetails("EEE","BE",11,6,"BEEE","bala",1200);
        BookDetails newBook3 = new BookDetails("ECE","BE",12,8,"DPST","bala",1400);

        newBook1.Display();
        newBook2.Display();
        newBook3.Display();

    }
}
