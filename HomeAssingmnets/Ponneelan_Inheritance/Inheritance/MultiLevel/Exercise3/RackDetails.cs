using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class RackDetails : Department
    {
        public int RackNumber { get; private set; }
        
        public int ColunmNumber { get; set; }

        public  RackDetails(string departmentName,string degree,int rackNumber,int colunmNumber):base(departmentName,degree)
        {
            RackNumber = rackNumber;
            ColunmNumber = colunmNumber;
        }
        
        
    }
}