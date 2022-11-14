using System;
namespace ByNumberOfArgument;

class Program
{
    public static void Main(string[] args)
    {
        Display(1,2);
        Display(1);
    }


     static void Display(int number1,int number2)
    {
        Console.WriteLine($"Number1  {number1} Number 2 {number2} ");
    }

     static void Display(int number1)
    
    {
        Console.WriteLine($"Number 1 {number1}");
    }


}