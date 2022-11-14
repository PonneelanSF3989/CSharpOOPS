using System;


namespace Exercise1;
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PersonalDetails detail = new PersonalDetails("ponneelan","ram","hi",458,"gigi",new DateTime(2005,08,12),"Male");
            detail.StatusInfo();    
            EmployeeDetails emp1= new EmployeeDetails("ponneelan","ram","hi",76,"abc.com",new DateTime(2109,10,10),"Male");
            emp1.StatusInfo();

            emp1.UpdateInfo();
            detail.UpdateInfo();
        }
    }
}