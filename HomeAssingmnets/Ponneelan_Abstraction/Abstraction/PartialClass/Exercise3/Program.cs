using System;
namespace Exercise3;

class Program
{
    public static void Main(string[] args)
    {
        Calculator newCalculator = new Calculator(5,9);
        newCalculator.Addition();
        newCalculator.Subtraction();
    }
}