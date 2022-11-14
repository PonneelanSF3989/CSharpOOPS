using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class SavingsAccount : BankInfo,ICalculate
    {
        public long AccountNumber { get; set; }
        public string Accountype { get; set; }
        public int  Balance { get; set; }

        public SavingsAccount(string name,int age,string gender,DateTime dob,string voterId,string aadhar, string panNumber,string bankName,string ifsc,string branch,long accNumber,string accType,int balance) :base(name,age,gender,dob,voterId,aadhar,panNumber,bankName,ifsc,branch)
        {
            AccountNumber = accNumber;
            Accountype = accType;
            Balance = balance;
        }

        public void  Deposite(int amount)
        {
            Balance += amount;
            
        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
        }

        public void CheckBalance()
        {
            Console.WriteLine("Balnce   "+Balance);
        }
        
        public void ShowDetails()
        {
            Console.WriteLine(Name+"    "+Accountype+"      "+Accountype+"      "+BankName+"     "+IFSC+"      "+AadharID+"    "+Balance);
        }
        
        
        
    }
}