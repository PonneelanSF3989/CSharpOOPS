using System;
namespace MultipleInhertence;

class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails person = new PersonalDetails("Ponneelan","Ramanatha,",Gender.male,DateTime.Today);
        

        StudentDetails student = new StudentDetails("AID1004","Ponneelan","Ramanathan",Gender.male,DateTime.Today,Department.ECE,Year.Fourth);
        student.GetMarkDetails(76.00);
        student.ShowStudent();
        
        
    }
}