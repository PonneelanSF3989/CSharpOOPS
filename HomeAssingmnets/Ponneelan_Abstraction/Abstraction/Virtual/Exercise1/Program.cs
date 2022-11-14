using System;
namespace Exercise1;

class program
{
    public static void Main(string[] args)
    {
        AreaCalculator area = new AreaCalculator();
        area.Calculate();
        area.Display();

        VolumeCalculator volume = new VolumeCalculator();
        volume.Calculate();
        volume.Display();
    }
}