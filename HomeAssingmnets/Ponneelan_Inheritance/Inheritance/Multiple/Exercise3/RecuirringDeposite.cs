using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class RecuirringDeposite : PersonalInfo, ICalculate
    {
        public long AccountNumber { get; set; }
        public string Accountype { get; set; }
        public int  Balance { get; set; }

        public RecuirringDeposite(string name,int age,string gender,DateTime dob,string voterId,string aadhar, string panNumber,string bankName,string ifsc,string branch,long accNumber,string accType,int balance) :base(name,age,gender,dob)
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
            Console.WriteLine(Name+"    "+Accountype+"      "+Accountype+"    "+Balance);
        }
    }
}