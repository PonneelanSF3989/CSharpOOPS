using System;
namespace Abstraction;
class Program
{
    public static void Main(string[] args)
    {
        Syncfussion job1 =  new Syncfussion();
        job1.Name = "Ponneelan";
        job1.Salary(30);

        TCS job2 = new TCS();
        job2.Name  = "vasanth";
        job2.Salary(30);
    }
}