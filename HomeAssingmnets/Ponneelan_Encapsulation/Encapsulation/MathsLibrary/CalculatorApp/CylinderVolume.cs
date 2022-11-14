using MathsLib;
namespace CalculatorApp
{
    public class CylinderVolume : CircleArea
    {
        CircleArea circle = new CircleArea();
        private int p_height = 10;
        public int Height { get; set; }

        internal double volume { get; set; }

        public double CalculateVolume()
        {
            Height = p_height;
           double x = circle.CalculateCircleArea();
            return x*Height ;
        }
        
        
        
        
    }
}