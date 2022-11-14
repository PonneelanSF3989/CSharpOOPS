using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class GetMarks
    {
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public int Mark4 { get; set; }
        public int Mark5 { get; set; }
        public int Mark6 { get; set; }

        public GetMarks(int mark1,int mark2,int mark3, int mark4, int mark5,int mark6)
        {
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
            Mark4= mark4;
            Mark5 = mark5;
            Mark6 = mark6;

        }
        public GetMarks()
        {

        }
        public static GetMarks operator + (GetMarks m1 ,GetMarks m2)
        {
            GetMarks addMark = new GetMarks();
            addMark.Mark1 = m1.Mark1 + m2.Mark1;
            addMark.Mark2 = m1.Mark2 + m2.Mark2;
            addMark.Mark3 = m1.Mark3 + m2.Mark3;
            addMark.Mark4 = m1.Mark4 + m2.Mark4;
            addMark.Mark5 = m1.Mark5 + m2.Mark5;
            addMark.Mark6 = m1.Mark6 + m2.Mark6;
            return addMark;

        }

        
    }
}