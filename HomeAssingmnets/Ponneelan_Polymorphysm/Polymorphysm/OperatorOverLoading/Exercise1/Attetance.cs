using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Attetance
    {
        public int TotalWorkindDaya { get; set; }
        public int  Leavetaken { get; set; }
        
        public int Permissions { get; set; }
        

        public Attetance(int totaldays,int leave,int permissions)
        {
            TotalWorkindDaya = totaldays;
            Leavetaken = leave;
            Permissions = permissions;
        }
        public Attetance(){}
        public static Attetance operator +(Attetance m1,Attetance m2)
        {
            Attetance Attetance = new Attetance();

            Attetance.TotalWorkindDaya = m1.TotalWorkindDaya + m2.TotalWorkindDaya;
            Attetance.Leavetaken = m1.Leavetaken + m2.Leavetaken;
            Attetance.Permissions = m1.Permissions + m2.Permissions;

            return Attetance;

        }
    }
}