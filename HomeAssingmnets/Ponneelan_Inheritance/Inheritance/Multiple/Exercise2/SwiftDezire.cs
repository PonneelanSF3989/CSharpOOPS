using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class SwiftDezire : Car,IBrand
    {
        private static int s_makingNumber = 1000;
        public string MakingID { get; set; }
        
        public string ChaseNumber { get; set; }
        
        public string EngineMuner { get; set; }

        public string BrandName { get; set; }
        
        public string ModelName { get; set; }
        
        
        
        public SwiftDezire(string fuelType,int seatsCount,string color,int tankCapacity,int kmDriven,string chaseNumber, string engineNumber,string modelName) : base(fuelType,seatsCount,color,tankCapacity,kmDriven)
        {
            s_makingNumber++;
            MakingID = "MID" + s_makingNumber;
            ChaseNumber = chaseNumber;
            EngineMuner  = engineNumber;
            ModelName = modelName;
        }

        public void ShowData()
        {
            Console.WriteLine(ModelName +"      " +BrandName +"     "+NumberOfSeat+"        "+Color+"       "+FuleType+"       "+TankCapacity+"       "+KMDrivern+"        "+ChaseNumber+"        "+EngineMuner+"      "+MakingID);
        }
        
    }
}