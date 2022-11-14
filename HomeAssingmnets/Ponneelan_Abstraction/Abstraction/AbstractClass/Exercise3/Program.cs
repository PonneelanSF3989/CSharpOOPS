using System;
namespace Exercise3;

class Program
{
    public static void Main(string[] args)
    {
        OnlineTicket online= new OnlineTicket();
        OflineTicket ofline= new OflineTicket();


        online.ShowTicket();
        ofline.ShowTicket();
    }
}