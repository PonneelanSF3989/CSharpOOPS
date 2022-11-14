using System;
namespace Exercise2;



class Diamention
{
    private int value1 =20;
    private int value2 = 20;
    private int area;

    public virtual void Calculate()
    {
        area = value1 * value2;
    }

    public virtual void Display()
    {
        Console.WriteLine("Area     "+area);
    }
}

class Rectangle : Diamention
{
    private int height = 10 ;
    private int lenght =10;
    private int area;

    public override void Calculate()
    {
        area = lenght * height;
    }

    public override void Display()
    {
        Console.WriteLine("Area     "+area);
    }
}

class Shpere :Diamention
{
    private int radius  = 10;
   
    private double area;

    public override void Calculate()
    {
        area = (radius * radius)* 3.14;
    }

    public override void Display()
    {
        Console.WriteLine("Area     "+area);
    }
}


class Program
{
    public static void Main(string[] args)
    {
        Diamention dia  = new Diamention();
        dia.Calculate();
        dia.Display();

        Rectangle rec= new Rectangle();
        rec.Calculate();
        rec.Display();

        Shpere shpere = new Shpere();
        shpere.Calculate();
        shpere.Display();
    }
}