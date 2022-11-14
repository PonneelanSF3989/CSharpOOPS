using System;
namespace Interfaces;

class Program
{
    public static void Main(string[] args)
    {
        
        Square newNumber = new Square();
        newNumber.Number =10;
        Console.WriteLine(newNumber.Calculate());

        ICalculate value =  new Square();
        value.Number = 20;
        Console.WriteLine(value.Calculate());
        
    }
}