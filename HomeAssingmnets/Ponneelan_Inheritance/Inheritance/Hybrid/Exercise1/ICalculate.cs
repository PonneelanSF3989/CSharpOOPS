

namespace Exercise1
{
    public interface ICalculate
    {
        public int Total { get; set; }
        
        public double Percentage { get; set; }
        
        public void Calculate(int[] marks,int[] mark2,int[] mark3, int[] mark4);
        
        
    }
}