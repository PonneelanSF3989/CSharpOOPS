using System;
namespace Exercise1
{
    public enum Year { Default, first, second, third }
    public class StudentDetails : PersonalDetails
    {
        private static int s_studentId = 1000;
        public string StudentId { get; }
        public string Department { get; set; }
        public Year Year { get; set; }
        public double CGPA { get; set; }
        public StudentDetails(){}
        public StudentDetails(string aId, string name, string fatherName, Gender gender, DateTime dob, string department, Year year)
        {
            this.Department = department;
            this.Year = year;
            s_studentId++;
            StudentId = "SID" + s_studentId;
        }

        public void GetMarkDetails(double cgpa)
        {
            CGPA = cgpa;
            System.Console.WriteLine("CGPA");
        }
        public override void ShowDetails()
        {
            System.Console.WriteLine("Aadhar-Id: " + PersonID);
            System.Console.WriteLine("Name: " + PersonName);
            System.Console.WriteLine("FatherName: " + FatherName);
            System.Console.WriteLine("Gender: " + Gender);
            System.Console.WriteLine("DOB: " + DOB);
        }

        public void ShowStudent()
        {
            System.Console.WriteLine("Student Id:" + StudentId);
            ShowDetails();
            System.Console.WriteLine("Year: " + Year);
            System.Console.WriteLine("Department" + Department);
        }

    }
}