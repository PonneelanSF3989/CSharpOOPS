using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Cardetails
    {
      
        public string RCBookNumber { get; set; }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }
        public int Milage { get; set; }
        public int TankCapacity { get; set; }
        public int NumberOfSeats { get; set; }
        public int NumberOfKmDriven { get; set; }
        public DateTime DateOfPurchase { get; set; }


        public Cardetails(string rcbookNumber,string engineNumber, string chaseNumber,int milage,int capacity, int seats,int kmDriven,DateTime buyDate)
        {
            RCBookNumber = rcbookNumber;
            EngineNumber = engineNumber;
            ChasisNumber = chaseNumber;
            Milage =milage;
            TankCapacity = capacity;
            NumberOfSeats = seats;
            NumberOfKmDriven = kmDriven;
            DateOfPurchase = buyDate;
        }

        public void ShowCarDetails()
        {
            Console.WriteLine(RCBookNumber+"    "+EngineNumber+"    "+ChasisNumber +"   "+Milage+"  "+TankCapacity+"    "+NumberOfSeats+"   "+NumberOfKmDriven+"    "+DateOfPurchase);
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        

        
        
        
    }
}