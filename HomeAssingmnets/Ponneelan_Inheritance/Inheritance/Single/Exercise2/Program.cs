using System;
namespace Exercise2;
class Program
{
    public static void Main(string[] args)
    {
        AccountDetails account = new AccountDetails("vasanth","ram",90909090,"kghjsc",new DateTime(2022,11,11),Gender.male,"AID1001",Acctype.SB,"SBIN10001",10000);
        
        account.ShoWAcountDetails();
       
  
    }
}