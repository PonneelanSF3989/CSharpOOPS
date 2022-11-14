using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerxise2
{
    public class MensWear:Dress
    {
        public MensWear(string name,int price)
        {
            DressName=name;
            Price=price;
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine("DressName: "+DressName);
            System.Console.WriteLine("Price: "+Price);
        }
    }
}