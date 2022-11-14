using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3;
public class PersonDetails
{
    public string Name { get; set; }
    
    public string FatherName { get; set; }
    
    public int Age { get; set; }
    
    public string Gender { get; set; }
    
    public PersonDetails(string name,string fatherName,int age,string gender)
    {
        Name =name;
        FatherName = fatherName;
        Age =age;
        Gender = gender;
    }

    public virtual void  Display()
    {
        Console.WriteLine(Name +"   "+FatherName+"  "+Age+"     "+Gender);
    }
}
