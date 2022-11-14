using System;
namespace Exercise2;

class Program
{
    public static void Main(string[] args)
    {
        SwiftDezire swift1 = new SwiftDezire("petron",4,"blue",30,10000,"CID1001","EID1000","dezire");
        Eco eco1 = new Eco("GAS",4,"blue",30,10000,"CID1001","EID1000","eco");


        swift1.ShowData();
        eco1.ShowData();
    }
}