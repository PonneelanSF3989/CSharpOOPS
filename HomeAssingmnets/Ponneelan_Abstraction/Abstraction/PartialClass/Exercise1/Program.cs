using System;
namespace Exercise1;

class Program
{
    public static void Main(string[] args)
    {
            Properties employee = new Properties("Ponneelan","Male","1111010101");
            employee.Display();
            employee.Update();
    }
}