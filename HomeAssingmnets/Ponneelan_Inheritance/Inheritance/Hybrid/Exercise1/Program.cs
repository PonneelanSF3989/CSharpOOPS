using System;
namespace Exercise1;

class Program
{
    public static void Main(string[] args)
    {
        int [] sem1 = {87,67,89,09,90,100};
        
        int [] sem2 = {87,67,89,09,90,100}; 
        int [] sem3 =  {87,67,89,09,90,100}; 
        int [] sem4 =  {87,67,89,09,90,100};
        Marksheets marksheet1 = new Marksheets("name","ramanathan",22,"male",909090909, new DateTime(2001,05,13),sem1,sem2,sem3,sem4,DateTime.Today);
        marksheet1.ShoeMarkSheet();
    }
}