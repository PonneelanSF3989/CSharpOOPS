using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public static  class Operators
    {
        private static List<StudentDetails> studentData = new List<StudentDetails>();
        private static List<TeachersDetails> teacherData = new List<TeachersDetails>();
        private static List<PrincipleDetails> principleData = new List<PrincipleDetails>();
        public static void AdduserData()
        {
            StudentDetails student1 = new StudentDetails("PID1001","Ponneelan","Ramanathan",9090900,"mailid",new DateTime(2001,05,13),Gender.Male,"SID1001",Degree.UG,Department.EEE,new DateTime(2022));
            StudentDetails student2 = new StudentDetails("PID1001","vasanth","Ramanathan",9090900,"mailid",new DateTime(2001,05,13),Gender.Male,"SID1002",Degree.UG,Department.EEE,new DateTime(2022));
            studentData.Add(student1);
            studentData.Add(student2);

            TeachersDetails teacher1 = new TeachersDetails("PID1003","Ponneelan","Ramanathan",9090900,"mailid",new DateTime(2001,05,13),Gender.Male,"TID1001",Department.EEE,"BEE","PG",5,new DateTime(2022));
            TeachersDetails teacher2 = new TeachersDetails("PID1004","Vasath","Ramanathan",9090900,"mailid",new DateTime(2001,05,13),Gender.Male,"TID1002",Department.EEE,"m1","PG",5,new DateTime(2022));
            teacherData.Add(teacher1);
            teacherData.Add(teacher2);

            PrincipleDetails principle1 = new PrincipleDetails("PID1005","Ponneelan","Ramanathan",9090900,"mailid",new DateTime(2001,05,13),Gender.Male,"PID1001","PG",5,new DateTime(2022));
            PrincipleDetails principle2 = new PrincipleDetails("PID1007","yc","Ramanathan",9090900,"mailid",new DateTime(2001,05,13),Gender.Male,"PID1002","PG",5,new DateTime(2022));
            principleData.Add(principle1);
            principleData.Add(principle2);
        }

        public static void MainMenu ()
        {
            int choice = 0;

            do
            {
                Console.WriteLine("\n1. Student Login");
                Console.WriteLine("\n1. Teacher Login");
                Console.WriteLine("\n1. Principle Login");
                Console.WriteLine("\nEnter your choice");
                choice = int.Parse(Console.ReadLine());
                switch(choice )
                {
                    case 1:
                    {
                        StudentLogin();
                        break;
                    }
                     case 2:
                    {
                        TeacherLogin();
                        break;
                    }
                     case 3:
                    {
                        PrincipleLogin();
                        break;
                    }
                }

            }while(choice !=4);
        }
        public static void StudentLogin()
        {
            bool flag =false;
            Console.WriteLine("Enter your Student id");
            string studentID = Console.ReadLine();
            foreach(StudentDetails student in studentData)
            {
                if (student.RegisterNumber == studentID)
                {
                    flag = true;
                    student.ShowStudentDetails();
                }
            }
            if(!flag)
            
            {
                Console.WriteLine("Student not fount");
            }

        }
         public static void TeacherLogin()
        {
            bool flag =false;
            Console.WriteLine("Enter your Teacher id");
            string teacherId = Console.ReadLine();
            foreach(TeachersDetails teacher in teacherData)
            {
                if (teacher.TeacherID == teacherId)
                {
                    flag = true;
                    teacher.ShowTeachersDetails();
                }
            }
            if(!flag)
            
            {
                Console.WriteLine("Teacher not fount");
            }

        }
         public static void PrincipleLogin()
        {
            bool flag =false;
            Console.WriteLine("Enter your principle id");
            string principleID = Console.ReadLine();
            foreach(PrincipleDetails principle in principleData)
            {
                if (principle.PrincipleID == principleID)
                {
                    flag = true;
                    principle.ShowPrincileDetails();
                }
            }
            if(!flag)
            
            {
                Console.WriteLine("Principle not fount");
            }

        }
    
    
    
    
    
    }
}