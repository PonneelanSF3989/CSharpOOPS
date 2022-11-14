using System;


namespace Exercise1
{
    public static class AllMethod
    {
       public  static void Method(int a)
    {
        System.Console.WriteLine("Single Argument");
        Console.WriteLine("Square of a "+(a*a));
    }

    public static void Method(int a,int b)
    {
        System.Console.WriteLine("two same Argument");

        Console.WriteLine("Adition of two "+(a+b));
    }
    public static void Method(int a,int b,int c)
    {
        System.Console.WriteLine("three same argument");
        Console.WriteLine("additio of three num of a "+(a+b+c));
    }
    public static void Method(int a, string b)
    {
        System.Console.WriteLine("two diffrent argument");
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
    public static void Method(int a,double b,string c)
    {
        System.Console.WriteLine("three diffrent argument");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
    }
    }
}