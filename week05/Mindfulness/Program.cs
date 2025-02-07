using System;
using System.Runtime.InteropServices;
using sport;

class Program
{
    static void Main(string[] args)
    {  
       while(true)
       {
            Console.WriteLine("Welcome TO Your Mindfulness");
            Console.WriteLine("===========================");
            Console.WriteLine("---------Activities--------");
            Console.WriteLine("1. Breath Activity.");
            Console.WriteLine("2. LIsting Activity");
            Console.WriteLine("3. Reflecting Activuty.");
            Console.Write("Choose ACtivity: ");
            string option =Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("Breathing Activity");
                string name = "Breathing Activity";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                Console.Write("Duration of activity:");
                Activity activity = new Activity();
                
            }
       } 
      
       

    }
}