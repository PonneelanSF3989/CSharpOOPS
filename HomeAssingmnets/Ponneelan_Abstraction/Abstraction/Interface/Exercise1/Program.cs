using System;

namespace Exercise1;

class Program
{
    public static void Main(string[] args)
    {
        Dog  dog1 = new Dog("pomeriam","bark","eat");
        Dog  dog2 = new Dog("tober","bark","eat");
        Dog  dog3 = new Dog("labrotor","bark","eat");
        Dog  dog4 = new Dog("cuntry","bark","eat");
        dog1.Display();
        dog2.Display();
        dog3.Display();
        dog4.Display();


        Duck duck1 = new Duck("duck1","fly","drink");
        Duck duck2 = new Duck("duck2","fly","drink");
        Duck duck3 = new Duck("duck3","fly","drink");
        Duck duck4 = new Duck("duck4","fly","drink");
        duck1.Display();
        duck2.Display();
        duck3.Display();
        duck4.Display();
        


    }
}