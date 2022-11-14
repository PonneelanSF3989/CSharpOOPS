using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class BankInfo : IDInfo
    {
        public string BankName { get; set; }
        
        public string IFSC { get; set; }
        
        public string Branch { get; set; }

        public BankInfo(string name,int age,string gender,DateTime dob,string voterId,string aadhar, string panNumber,string bankName,string ifsc, string branch) : base(name,age,gender,dob,voterId,aadhar,panNumber)
        {
            BankName = bankName;
            IFSC  = ifsc;
            Branch = branch;
        } 
        
        
    }
}