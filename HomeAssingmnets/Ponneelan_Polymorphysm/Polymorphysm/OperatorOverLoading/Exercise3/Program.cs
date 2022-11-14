using System;
namespace Exercise3;
class program
{
    public static void Main(string[] args)
    {
        Addition add1 = new Addition(12,90);
        Addition add2 = new Addition(20,10); 

        Console.WriteLine(add1+add2);
    }
}