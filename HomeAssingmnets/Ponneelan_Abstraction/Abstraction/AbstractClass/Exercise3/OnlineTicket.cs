using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class OnlineTicket : Ticket
    {
       public override string Type { get; set; }

       public override int  SeatNumber { get; set; }

        public override void BookTicket()
        {
            TheaterName = "raj";
            ticketID++;
            TickerID ="TID"+ ticketID;
           
            Price = 100;
            Type = "online";
             SeatNumber = 10;

        }
       public override void ShowTicket()
       {
        BookTicket();
        Console.WriteLine("Online Ticket");
        Console.WriteLine(TheaterName+" "+TickerID+"    "+Price+"  "+Type+"    "+SeatNumber);

       }
       
       
       
       

        
        
        
        
    }
}