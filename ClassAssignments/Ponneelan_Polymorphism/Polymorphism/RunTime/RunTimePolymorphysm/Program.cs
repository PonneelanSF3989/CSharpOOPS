using System;
namespace RunTimePolymorphysm;


class Student 
{
   public string Name { get; set; }
  
    public virtual void Display()
    {
        Console.WriteLine(Name);
    }
}

class SportMark : Student
{
public int spotMark = 50;
    public override void Display()
    {
        Console.WriteLine($"{Name}   {spotMark}");
    }
}

class Total : SportMark
{
   public static int academicMark = 90;
   public int TotalMark{get;set;}

   

    
    public override void Display()
    {
        Console.WriteLine($"");
    }
}