using System;
namespace Exercise3;


public class Drawing 
{
    public virtual void Draw()
    {
        Console.WriteLine("Draw");
    }
}

public class DrawStar : Drawing
{
    public override void Draw()
    {
        Console.WriteLine("Draw stra");
    }
}

public class DrawLine : Drawing
{
    public override void Draw()
    
    {
        System.Console.WriteLine("Draw Line");
    }
}


class Program
{
    public static void Main(string[] args)
    {
        Drawing draw = new Drawing();
        draw.Draw();
        DrawLine line = new DrawLine();
        line.Draw();
        DrawStar star = new DrawStar();
        star.Draw();
    }
}