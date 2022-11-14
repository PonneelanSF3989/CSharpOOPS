using System;
namespace Exercise2;
class Program
{
    public static void Main(string[] args)
    {
        GetMarks sem1 = new GetMarks(78,66,98,67,90,65);
        GetMarks sem2 = new GetMarks(76,90,68,56,87,65);
        GetMarks sem3 = new GetMarks(70,66,98,77,80,65);
        GetMarks sem4 = new GetMarks(74,67,91,47,50,65);
        GetMarks allSem = new GetMarks();

        allSem = sem1 + sem2;
        allSem = allSem + sem3;
        allSem = allSem + sem4;

        Console.WriteLine("Mark1    "+allSem.Mark1/4);
        Console.WriteLine("Mark2    "+allSem.Mark2/4);
        Console.WriteLine("Mark3    "+allSem.Mark3/4);
        Console.WriteLine("Mark4    "+allSem.Mark4/4);
        Console.WriteLine("Mark5    "+allSem.Mark5/4);
        Console.WriteLine("Mark6    "+allSem.Mark6/4);
        int total = (allSem.Mark1 + allSem.Mark2 + allSem.Mark3 + allSem.Mark4+ allSem.Mark5 + allSem.Mark6);
        float percentage = (float)(total/600) * 100;
        Console.WriteLine("\nPercentage1    "+ percentage);



    }
}