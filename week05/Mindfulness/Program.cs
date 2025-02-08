using System;
using System.Runtime.InteropServices;
using activity;

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
            Console.Write("Choose Activity: ");
            string option =Console.ReadLine();

            if (option == "1")
            {
                string name = "Breathing Activity";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                Console.WriteLine();
                Console.Write("Time duration for your activity in seconds: ");
                string du = Console.ReadLine();
                Console.WriteLine();
                int duration = int.Parse(du);

                Activity activity = new Activity(name,description,duration);
                activity.DisplayStartingMessage();

                Console.Clear();
                Console.WriteLine("Get ready....");
                activity.ShowSpinner(duration);
          
                
                activity.DisplayEndingMessage();
                
            }
       } 
      
       

    }
}