using System;
namespace Exercise3;
class Program

{
    public static void Main(string[] args)
    {
        MaruthiCar maruthi = new MaruthiCar("rc10001","eid10001","cid1001",20,40,4,10000,new DateTime(2018,10,10),"maruthi","101");
        TataCar tata = new TataCar("rc10001","eid10001","cid1001",20,40,4,10000,new DateTime(2018,10,10),"maruthi","101");
   
        tata.showCar();
        maruthi.showCar();
    
    }
}