using System;
namespace Exercise3;
class Program
{
    public static void Main(string[] args)
    {
            Ofline off = new Ofline();
            off.Purchase[0] = 10;
            off.Purchase[1] = 20;
            off.Purchase[2] = 30;
            off.Purchase[3] = 10;
            off.Purchase[4] = 50;

            off.PurchaseDate = new DateTime(2011,12,11);
            off.Calculate();
            off.Display();

            Online online = new Online();
            online.Purchase[0] = 10;
            online.Purchase[1] = 12;

            online.PurchaseDate = new DateTime(2022,11,11);
            online .Calculate();
            online.Display();

    }
}