using System;
namespace Exercise1;

class program
{
    public static void Main(string[] args)
    {
        CSE cse1 = new CSE();
        cse1.SetBookIfno();
        cse1.Display();


        EEE eee1 = new EEE();
        eee1.SetBookIfno();
        eee1.Display();
    }
}