using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Exerxise2


{
    public class LadiesWear : Dress
    {
        public LadiesWear(string dressName,int price)
        {
            DressName=dressName;
            Price=price;
        }

        public override void DisplayInfo()
        {
            System.Console.WriteLine("DressName : "+DressName+"\n"+"Price : "+Price);
            System.Console.WriteLine();
        }
    }
}