using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Duck :Animal
    {
        
        public string Name { get; set; }
        public string Habit { get; set; }
        
        public string EatingHabit { get; set; }
        
        public Duck(string name,string habit,string eating)
        {
            Name = name;
            Habit = habit;
            EatingHabit = eating;
        }
        public void Display()
        {
            Console.WriteLine("Name    "+Name);
        }
    }
}