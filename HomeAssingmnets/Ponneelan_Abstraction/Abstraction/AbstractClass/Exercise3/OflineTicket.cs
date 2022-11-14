using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class OflineTicket : Ticket
    {
         public override string Type { get; set; }

       public override int  SeatNumber { get; set; }

        public override void BookTicket()
        {
            TheaterName = "meruga";
            ticketID++;
            TickerID ="TID"+ ticketID;
           
            Price = 150;
            Type = "ofline";
             SeatNumber = 50;

        }
       public override void ShowTicket()
       {
        BookTicket();
        Console.WriteLine("Ofline Ticket");
        Console.WriteLine(TheaterName+" "+TickerID+"    "+Price+"  "+Type+"    "+SeatNumber);

       }
    }
}