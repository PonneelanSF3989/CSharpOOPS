using MathsLib;
namespace CalculatorApp
{
    public class CircleArea : Maths
    {
        protected int p_radius = 5;
        public int Radius { get; set; }
        internal double Area { get; set; }

       public   double CalculateCircleArea()
       {
        return 3.14 * (Radius*Radius);
       }

       
       
       
       
        
           
        
        
        
    }
}