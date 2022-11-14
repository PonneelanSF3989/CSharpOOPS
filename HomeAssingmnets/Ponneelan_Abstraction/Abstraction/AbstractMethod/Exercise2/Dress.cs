using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerxise2
{
    public abstract class Dress
    {
        public string DressName { get; set; }
        public int Price { get; set; }
        public abstract void DisplayDetails();
    }
}