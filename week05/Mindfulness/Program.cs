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
                activity.ShowSpinner(5);

                Console.WriteLine();
                BreathingActivity breath = new BreathingActivity(name,description,duration);
                breath.Run();
                activity.ShowSpinner(3);
                Console.Clear();
                activity.DisplayEndingMessage();
                Console.WriteLine();
            }

            else if (option == "2")
            {
                string name = "Reflecting Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Console.WriteLine();
                Console.Write("Time duration for your activity in seconds: ");
                string du = Console.ReadLine();
                Console.WriteLine();
                int duration = int.Parse(du);

                Activity activity = new Activity(name,description,duration);
                activity.DisplayStartingMessage();

                ReflectingActivity reflectingActivity = new ReflectingActivity();
                Console.WriteLine(reflectingActivity.GetRandomPrompt());
            }
       } 
      
       

    }
}