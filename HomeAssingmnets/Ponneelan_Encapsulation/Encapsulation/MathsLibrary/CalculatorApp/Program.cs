using System;
using MathsLib;
namespace CalculatorApp;

class Program
{
    public static void Main(string[] args)
    {


        //new object to the MathsLib Project
        Maths math =  new Maths();
        //claa the Calculatedweight method using math object
        double weight = math.CalculateWeight(4);
        Console.WriteLine(weight);


        //new object for the class Cylinder volume
        CylinderVolume cylinedrVolume = new CylinderVolume();
        //call the method inside the class using object
        double x = cylinedrVolume.CalculateVolume();
        Console.WriteLine(x);
        //call the calculate weight using cylinder class obejct
        Console.WriteLine(cylinedrVolume.CalculateWeight(4));
        Console.WriteLine(cylinedrVolume.CalculateCircleArea());


        CircleArea circleArea = new CircleArea();
        double y = circleArea.CalculateCircleArea();
        Console.WriteLine(y);
        //using circle area object
        Console.WriteLine(circleArea.CalculateWeight(4));
        Console.WriteLine();

        
    }
}