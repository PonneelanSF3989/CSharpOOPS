using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiPath
{
     interface IAcademic : IStudent
    {
        public int  AcademicMark { get; set; }
        
        
    }
}