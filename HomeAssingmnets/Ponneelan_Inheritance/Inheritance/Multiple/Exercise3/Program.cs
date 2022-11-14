using System;
namespace Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            SavingsAccount newAccount  =  new SavingsAccount("Vasanth",22,"male",new DateTime(2022,05,12),"voter11","1234567891011","EXe12344","sbi","sbin1001","chennai",90909090,"Savings",1000);
            newAccount.ShowDetails();
            newAccount.Deposite(1000);
            newAccount.ShowDetails();
            newAccount.Withdraw(500);
            newAccount.CheckBalance();


            RecuirringDeposite rcDecposite  =  new RecuirringDeposite("Vasanth",22,"male",new DateTime(2022,05,12),"voter11","1234567891011","EXe12344","kvb","sbin1001","chennai",90909090,"Savings",1000);
            rcDecposite.ShowDetails();
            rcDecposite.Deposite(2000);
            rcDecposite.CheckBalance();
            rcDecposite.Withdraw(1000);
            rcDecposite.CheckBalance();
        }
    }
}