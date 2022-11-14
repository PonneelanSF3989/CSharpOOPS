using System;
namespace HeriarchicalInhertance;

class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails person = new PersonalDetails("Ponneelan","Ramanatha,",Gender.male,DateTime.Today);
        

        //StudentDetails student = new StudentDetails("AID1004","Ponneelan","Ramanathan",Gender.male,DateTime.Today,Department.ECE,Year.Fourth);
        //student.ShowStudent();

        AccountDetails account =  new AccountDetails("AID1001","ponnelan","ram",Gender.male,DateTime.Today,AccountType.sb);
        account.ShowAccountDetails();
        
    }
}