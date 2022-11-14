using System;
namespace MultiLevel;

class Program 
{
    public static void Main(string[] args)
    {
       // PersonalDetails person = new PersonalDetails("Ponneelan","Ramanatha,",Gender.male,DateTime.Today);
        

        // StudentDetails student = new StudentDetails("AID1004","Ponneelan","Ramanathan",Gender.male,DateTime.Today,Department.ECE,Year.Fourth);
        // student.ShowStudent();

        EmploymentDetails employee = new EmploymentDetails("AID1003","Ponneelan","Ramanathan",Gender.male,new DateTime(2001,05,13),"STU1001",Department.EEE,DateTime.Today);
        employee.ShowEmployyeDetails();
    }
}