using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{

    public abstract class Ticket
    {
        protected static int ticketID = 1000;
        public string TickerID { get; set; }
        public string TheaterName { get; set; }
        
        public int  Price { get; set; }
        
        public abstract string Type { get; set; }
        public abstract int SeatNumber { get; set; }
        
        public abstract void BookTicket ();    
        public abstract void ShowTicket();
        
    }
}