using System;
namespace Exercise2;
class Program
{
    public static void Main(string[] args)
    {
        TemporaryEmployee tempEmployee1 = new TemporaryEmployee(10000,"may","eid1000","ponneelan","Permenent",12000,15000);
        PermanentEmployee permenentEmployee = new PermanentEmployee(10000,"may","eid1000","ponneelan","Permenent",12000,15000);


        tempEmployee1.ShowDetails();
        permenentEmployee.ShowDetails();
    }
}