using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Ofline :  ITransaction
    {
        private int _amount;
        public int Amount { get{return _amount;} set{_amount = value;} }
        
        
        public string ransactionId { get; set; }
        private int[] _purchase = new int[5];
        public int[] Purchase { get{return _purchase;} set{_purchase = value;} }
        public DateTime PurchaseDate { get; set; }
        
        public void Calculate()
        {
            
            foreach(int items in Purchase)
            {
                Amount += items;
            }
            
        }

        public void Display()
        {
            Console.WriteLine("Amount   "+Amount);
        }
        
    }
}