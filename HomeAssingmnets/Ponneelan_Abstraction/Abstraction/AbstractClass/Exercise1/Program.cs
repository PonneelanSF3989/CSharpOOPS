using System;
namespace Exerise1;
class Program
{
    public static void Main(string[] args)
    {
        Cylinder cy = new Cylinder();
        cy.Height = 10;
        cy.Width = 10;
        cy.Radius =4;
        cy.Display();



        Cubes cube = new Cubes();
        cube.a = 10;
        cube.Display();
    }
}