using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public static  class Operators
    {
        private static List<StudentDetails> studentData = new List<StudentDetails>();
        public static void MainMenu()
        {
           
            int choice;
            do
            {
                
                Console.WriteLine("\n1. Login");
                Console.WriteLine("\n2 .Exit");
                Console.WriteLine("\nEnter your Choice ");
                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                    {
                        Login();
                        break;
                        
                    }
                    case 2:
                    {
                        
                        break;
                    }
                    default :
                    {
                        Console.WriteLine("Invalid choice");
                        break;
                    }
                }
            }while(choice !=2);

        }
        public static void AddDefaultData()
        {
            StudentDetails student1 = new StudentDetails("PID1001","Ponneelan","Ramanathan",9090900,"mailid",new DateTime(2001,05,13),Gender.male,"SID1001",Standart.Tenth,Branch.A,new DateTime(2022));
            StudentDetails student2 = new StudentDetails("PID1001","vasanth","Ramanathan",9090900,"mailid",new DateTime(2001,05,13),Gender.male,"SID1002",Standart.Twelth,Branch.B,new DateTime(2022));
            studentData.Add(student1);
            studentData.Add(student2);
        
        }
        public static void Login()
        {
            bool flag  = false;
            Console.WriteLine("Enter the Student id to login ");
            string studentID = Console.ReadLine();
            foreach(StudentDetails student in studentData)
            {
                if (student.RegisterNumber == studentID)
                {
                    flag =true;
                    student.ShowInfo();
                    
                }
            }
            if (!flag)
            {
                Console.WriteLine("invalid user Id");
            }

        }
    
    }
}