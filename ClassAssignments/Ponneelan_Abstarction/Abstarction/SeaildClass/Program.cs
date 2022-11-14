using System;
namespace SeaildClass;



public class LivingAnimal
{


}

public sealed class Animal : LivingAnimal
{

}

public class Dof : Animal
{

}



class Program
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
    }
}
