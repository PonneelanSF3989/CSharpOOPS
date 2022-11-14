using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MarkSheet ms = new MarkSheet("Madhu", "mithan", 09898, new DateTime(2000, 11, 11), "Male", 99, 45, 45, 53);
            ms.CalculateUG();
            ms.ShowMarkSheet();

        }
    }
}