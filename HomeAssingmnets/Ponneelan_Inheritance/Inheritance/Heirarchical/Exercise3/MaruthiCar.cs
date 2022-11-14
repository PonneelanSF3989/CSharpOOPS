using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class MaruthiCar : Cardetails
    {
        public string CarModelNumber { get; set; }
        public string CarModelName { get; set; }
    public MaruthiCar(string recNumber,string engineNumber,string chaseNumber,int milage,int capacity,int seats,int km,DateTime buyDate, string carModelNumber,string modelName) : base( recNumber, engineNumber, chaseNumber, milage, capacity, seats, km, buyDate)
        {
            CarModelNumber = carModelNumber;
            CarModelName = modelName;
        }

         public void showCar()
        {
            Console.WriteLine(CarModelName+"    "+CarModelNumber);
            ShowCarDetails();
        }

    }
}