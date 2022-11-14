using System;
namespace ByType;

class Program
{
    public static void Main(string[] args)
    {
        Display("Vasanth","rilan");
        Display(1,2);
    }


     static void Display(string name1,string name2)
    {
        Console.WriteLine("string type");
        Console.WriteLine($"Name1  {name1} Name2 {name2} ");
    }

    static void Display(int number1,int number2)
    {
        Console.WriteLine("integer type");
        Console.WriteLine($"Number1  {number1} Number2 {number2} ");
    }


    


}