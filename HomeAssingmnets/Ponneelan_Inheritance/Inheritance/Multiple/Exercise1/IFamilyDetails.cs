using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public  interface IFamilyDetails  : IShowData
    {
        public string FatherName { get; set; }
        
        public string MotherName { get; set; }
        
        public string Homeaddres { get; set; }
        
        public int NumberOfSibilings { get; set; }

        public void ShowData();
        
        
      

        
       
    }
}