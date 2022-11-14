using System;
namespace Exercise2;

class Program
{
    public static void Main(string[] args)
    {
        SalaryDetails salry = new SalaryDetails("PID1001","Ponneelan","Ramanathan",9090900,"mailid",new DateTime(2001,05,13),Gender.male,DateTime.Now,8,"jume",10000);
        salry.ShowSalaryDetails();
    }
}