using System;
namespace Exercise2;
class Program
{
    public static void Main(string[] args)
    {
        EEEDepartment eee = new EEEDepartment();
        CSE cse = new CSE();

        eee.Display();
        cse.Display();
    }
}