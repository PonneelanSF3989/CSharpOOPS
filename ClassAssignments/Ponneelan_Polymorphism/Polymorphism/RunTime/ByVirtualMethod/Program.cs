using System;
namespace ByVirtualMethod;


public class Animal
{
    public virtual void Eat()
    {
        System.Console.WriteLine("Animal Eat food");
    }
}

public class Dog : Animal
{
    public override void Eat()
    {
        System.Console.WriteLine("Eat Dog foot");
    }
}


public class Pomerian : Dog
{
    public override void Eat()
    {
        System.Console.WriteLine("Eat Pomerian food");
    }
}


class Program
{
public static void Main(string[] args)
{
    Animal animal = new Animal();
    animal.Eat();

    Dog dog1 = new Dog();
    dog1.Eat();

    Pomerian poneria1 = new Pomerian();
    poneria1.Eat();
}
}

