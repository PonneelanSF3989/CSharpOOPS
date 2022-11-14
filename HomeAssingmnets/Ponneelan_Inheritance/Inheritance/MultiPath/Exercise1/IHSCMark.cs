using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public interface IHSCMark : IPersonalInfo
    {
        public string MarkSheetNumber { get; set; }
        
        public int  PhysicsMark { get; set; }
        
        public int ChemistryMark { get; set; }
        
        public int MathMarks { get; set; }
        
        public int HSCTotal { get; set; }
        
        public double  HSCPercentage { get; set; }

        public void ShowMarkSheet();

        

        public void Calculate();
      



        
        
    }
}