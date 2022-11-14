using System;
namespace Hybrid;

class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails person = new PersonalDetails("Ponneelan","Ramanatha,",Gender.male,DateTime.Today);
        

        // //StudentDetails student = new StudentDetails("AID1004","Ponneelan","Ramanathan",Gender.male,DateTime.Today,Department.ECE,Year.Fourth);
        // student.GetMarkDetails(76.00);
        // student.ShowStudent();
        EmploymentDetails employment = new EmploymentDetails("AID1004","Ponneelan","Ramanathan",Gender.male,DateTime.Today,"SID1001",Department.ECE, new DateTime(2022/11/1));
        
         employment.GetMarkDetails(9.0);
         employment.ShowEmployyeDetails();
       
        
        
    }
}