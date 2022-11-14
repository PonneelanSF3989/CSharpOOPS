namespace MathsLib;

public class Maths
{
    protected internal double  PI = 3.14;
    internal double G = 9.8;

    public double CalculateWeight(int mass)
    {
        return mass * G;
    }
}
