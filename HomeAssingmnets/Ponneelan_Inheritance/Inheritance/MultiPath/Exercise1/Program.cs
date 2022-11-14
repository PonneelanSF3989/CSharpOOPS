using System;
namespace Exercise1;

class Program
{
    public static void Main(string[] args)
    {
        Application newApplication = new Application("Vasanth","ramanathan",22,"male",new DateTime(1111,11,1),89,90,87,90,87,50,76);

        newApplication.ShowMarkSheet();
        
    }
}