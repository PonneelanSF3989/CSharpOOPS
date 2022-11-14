using System;
namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            SavingsAccount newAccount  =  new SavingsAccount("name",22,"male",new DateTime(2022,05,12),"voter11","1234567891011","EXe12344","sbi","sbin1001","chennai",90909090,"Savings",1000);
            newAccount.ShowDetails();
            newAccount.Deposite(1000);
            newAccount.ShowDetails();
            newAccount.Withdraw(500);
            newAccount.CheckBalance();
        }
    }
}