using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Hybrid
{
    public interface IMarkDetails 
    {
         Double  CGPA { get; set; }

         void  GetMarkDetails(double cgpa) ;
        
        
        
    }
}