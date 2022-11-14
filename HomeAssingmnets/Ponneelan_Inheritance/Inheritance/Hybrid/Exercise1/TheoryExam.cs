using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class TheoryExam : StudentDetails
    {
        public int[] Sem1 { get; set; }
        public int[] Sem2 { get; set; }
        
        public int[] Sem3 { get; set; }
        
        public int[] Sem4 { get; set; }
        

        public TheoryExam (string name,string fatherName,int age,string gender,long phoneNumber,DateTime dob,int[] sem1,int[] sem2,int[] sem3,int[] sem4) : base(name,fatherName,age,gender,phoneNumber,dob)
        {
            Sem1 = sem1;
            Sem2 = sem2;
            Sem3 = sem3;
            Sem4 = sem4;
        }
        
    }
}