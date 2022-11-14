using System;
namespace  Exercise1;
class Program
{
    public static void Main(string[] args)
    {
        Attetance month1 = new Attetance(30,10,2);
        Attetance month2 = new Attetance(30,0,3);
        Attetance month3 = new Attetance(30,2,5);

        Attetance total = new Attetance();

        total = month1+month2;
        total = total+month3;

        Console.WriteLine("Total Working Days   " + total.TotalWorkindDaya);
        Console.WriteLine("Leaves   "+total.Leavetaken);
        Console.WriteLine("Permissions      "+total.Permissions);


    }    
}