using System;
namespace PartialClass;

class Program
{
    public static void Main(string[] args)
    {
        Employee newEmployee = new Employee(1000,"Vasanth");

        newEmployee.Display();
    }
}