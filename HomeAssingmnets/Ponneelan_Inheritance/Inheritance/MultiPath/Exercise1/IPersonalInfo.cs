using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public interface IPersonalInfo
    {
        public string PersonName { get; set; }
        
        public string FatherName { get; set; }
        
        public int  Age { get; set; }
        
        public DateTime DOB { get; set; }
        public string Gender { get; set; }

    }
}