using System;
namespace Exercise2;

class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "Vasanth";
        student.StudentID = "SID1001";
        student.FatherName = "vasanth";

        student.Display1();


        Employee employee = new Employee();
        employee.EmployeeId = "EID1000";
        employee.EmployeeName = "Ponneelan";
        employee.FatherName = "deva";

        employee.Display1();

    }
}