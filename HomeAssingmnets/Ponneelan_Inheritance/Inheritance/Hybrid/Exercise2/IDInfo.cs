using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class IDInfo : PersonalInfo
    {
        public string VoterId { get; set; }
        
        public string AadharID { get; set; }
        
        public string PANNumber { get; set; }
        
        public IDInfo(string name,int age,string gender,DateTime dob,string voterId,string aadhar, string panNumber) : base(name,age,gender,dob)
        {
            AadharID = aadhar;
            VoterId = voterId;
            PANNumber = panNumber;
        }
    }
}