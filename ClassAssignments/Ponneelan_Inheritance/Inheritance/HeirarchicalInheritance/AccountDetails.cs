using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeriarchicalInhertance
{
    public enum AccountType {Default,sb,rb}
    public class AccountDetails : PersonalDetails
    {
        private static int s_accountId = 1000;
        public string AccountNumber { get;  }
        public AccountType AccType {get; set ;}
        
   

    public AccountDetails(string AID , string name ,string fatherName, Gender gender,DateTime dob,AccountType accType) :base(AID,name,fatherName,gender,dob)
    {
        s_accountId++;
        AccountNumber = "AC" + s_accountId;
        AccType = accType;
    }

    public void ShowAccountDetails()
    {
        Console.WriteLine($"Account Number : {AccountNumber}");
        ShowDetails();
        Console.WriteLine($"Account Type : {AccType}");
    }

    }
}