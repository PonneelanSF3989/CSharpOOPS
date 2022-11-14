using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecercise1
{
    public static class Operatprs
    {
        private static List<HscMarkDetails> hscMarkData = new List<HscMarkDetails>();
        public static void MainMenu()
        {
            bool flag = false;
            Console.WriteLine("Enter mark Sheet id to login");
            string markSheetId  = Console.ReadLine();

            foreach(HscMarkDetails hscData in hscMarkData)
            {
                if (hscData.HSCMarksheetNumber == markSheetId)
                {
                    flag = true;
                    hscData.ShowHcsDetailss();
                }
            }
            if(!flag)
            {
                Console.WriteLine("invalid Id");
            }

        }

        public static void AddDefaultData()
        {
            HscMarkDetails hscData1 = new HscMarkDetails("PID1001","Ponneelan","Ramanathan",9090900,"mailid",new DateTime(2001,05,13),Gender.male,"SID1001",Standart.Tenth,Branch.A,new DateTime(2022),"SID1001",75,76,89);
            HscMarkDetails hscData2 = new HscMarkDetails("PID1002","vasa","Ramanathan",9090900,"mailid",new DateTime(2001,05,13),Gender.male,"SID1002",Standart.Tenth,Branch.A,new DateTime(2022),"SID1002",75,76,89);
            hscMarkData.Add(hscData1);
            hscMarkData.Add(hscData2);
        }
    }

}