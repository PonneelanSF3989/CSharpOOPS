using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public enum Acctype {Default,SB,RD}
    public class AccountDetails : PersonDetails
    {
        private static int  accNumber = 1000;
        public string AccountNumber { get; set; }
        public Acctype AccountType  { get; set; }
        public int Balance { get; set; }
        
        public string IFSC{ get; set; }
        
        public AccountDetails (string name,string fatherName, long phoneNumber, string mailID, DateTime dob, Gender gender,string accNumber ,Acctype accountType,string ifsc, int bal) : base( name, fatherName,  phoneNumber,  mailID,  dob,  gender)
        {
            AccountNumber = accNumber;
            AccountType = accountType;
            Balance = bal;
            IFSC = ifsc;
        }


        public  void ShoWAcountDetails()
        {
            Console.WriteLine(AccountNumber);
            Console.WriteLine(PersonName);
            Console.WriteLine(FatherName);
            Console.WriteLine(DOB);
            Console.WriteLine(PersonGender);
            Console.WriteLine(PhoneNumber);
            Console.WriteLine(Mail);
            Console.WriteLine(AccountType);
            Console.WriteLine(IFSC);
            Console.WriteLine(Balance);
        }
        
        
        
        
    }
}