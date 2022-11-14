using System;


namespace Exercise1
{
     interface Animal
    {
        public string Name { get;  set; }
        
        public string Habit { get; set; }
        
        public string EatingHabit { get; set; }

        void Display();

        // void print()
        // {
        //     Console.WriteLine("print");
        // }
        
        
    }
}