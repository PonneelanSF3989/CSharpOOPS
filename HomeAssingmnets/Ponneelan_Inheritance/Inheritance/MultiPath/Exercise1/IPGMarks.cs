using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public interface IPGMarks : IPersonalInfo
    {
       
        public string MarkSheetNumber { get; set; }
        
        public int  Sem1 { get; set; }
        
        public int  Sem2 { get; set; }
        
        public int  Sem3 { get; set; }
        
        public int  Sem4 { get; set; }

        public int  PGTotal { get; set; }
        
        public double PGPercentage { get; set; }
        

        public void Calculate();
    
        public void ShowMarkSheet();
        
        
    }
}