using System;
namespace Exercise3;

class Program
{
    public static void Main(string[] args)
    {
        Calculate(10);
        Calculate(10.9);
        Calculate(1000000000000);
        Calculate(20.78788);
    }



    static void Calculate(int a)
    {
        System.Console.WriteLine(a*a);
    } 

    static void Calculate(float s)
    {
        System.Console.WriteLine(s*s);
    }

    static void Calculate(double a)
    {
        Console.WriteLine(a *a);
    }
    static void Calculate(long a)
    {
        Console.WriteLine(a * a);
    }
}