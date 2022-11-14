using System;
namespace Exercise2;

class Program
{
    public static void Main(string[] args)
    {
        FreeLancer fr = new FreeLancer("vasanth","ramanathan",20,"",500,20);
        fr.Calculate();
        fr.Display();

        Syncfusion sf = new Syncfusion("ponneelan","ramanathan",20,"office",500,20,"chennai");

        sf.Calculate();
        sf.Display();

        
    }
}