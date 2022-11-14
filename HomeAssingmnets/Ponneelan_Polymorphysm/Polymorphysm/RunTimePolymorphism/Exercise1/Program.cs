using System;
namespace  Exercise1;

class Exercise1
{
    public static void Main(string[] args)
    {
        Attendance newAttend = new Attendance(13,19,8);
        newAttend.TotalSalary();
        newAttend.ShowDetails();

        PersonalDetails person = newAttend;
        person.ShowDetails();
        
        StudentDetails student = new StudentDetails();
        student.ShowStudent();
        student.ShowDetails();

        PersonalDetails person1 = student;
        person1.ShowDetails();

    }
}