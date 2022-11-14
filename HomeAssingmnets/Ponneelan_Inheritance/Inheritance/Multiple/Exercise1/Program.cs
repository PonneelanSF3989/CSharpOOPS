using System;
namespace Exercise1;
class Program
{
    public static void Main(string[] args)
    {
        Registration person  = new Registration("vasanth",new DateTime(1111,11,1),22,"Ramanathan","Ponmozhi","chennai",3,DateTime.Today);
        person.ShowData();
    
    }
}