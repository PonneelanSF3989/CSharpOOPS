using System;
namespace Exercise1;




class Person
{
    public string Name { get; set; }
    
    public string FatherName { get; set; }
    
    public long Mobile { get; set; }
    
    public string Mail { get; set; }
    
    public void UpdateInfo(){}
    
}


public sealed class EmployeeInfo
{
    public string EmployeeID { get; set; }
    
    public string Password { get; set; }
    
    public string KeyInfo { get; set; }
    
    public EmployeeInfo(string empid,string pass,string keyInfo)
    {
        EmployeeID = empid;
        Password =pass;
        KeyInfo = keyInfo;
    }
    public void Update()
    {
        Password = "whjf";
    }
    public void Display()
    {
        Console.WriteLine(EmployeeID+"  "+Password+"    "+KeyInfo);
    }
}


class Hack ///: EmployeeInfo 'Hack': cannot derive from sealed type 'EmployeeInfo'
{
    public string StoreUserID { get; set; }
    
    public string StorePassWord { get; set; }
    
    public void  UpdateInfo(){}
    public void GetUserInfo(){}
}
class Program
{
   public static void Main(string[] args)
   {
    EmployeeInfo emp = new EmployeeInfo("emp1000","pass","key");
    emp.Display();
    emp.Update();
    emp.Display();



    Hack hack  = new Hack();
    ////Console.WriteLine(hack.KeyInfo);  
    ///'Hack' does not contain a definition for 'KeyInfo' and no accessible extension method 'KeyInfo' 
   }

}