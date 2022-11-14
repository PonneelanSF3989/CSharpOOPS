using System;


namespace Exercise2
{
    public class Car
    {
        public string FuleType { get; set; }
        public int  NumberOfSeat { get; set; }
        public string Color { get; set; }
        
        public int TankCapacity { get; set; }
        
        public int KMDrivern { get; set; }
        
        public Car(string fuleType,int seatsCount,string color,int tankCapacity,int kmDriven)
        {
            FuleType  = fuleType;
            NumberOfSeat = seatsCount;
            Color = color;
            TankCapacity = tankCapacity;
            KMDrivern = kmDriven;
        }
        
        
        
        
    }
}