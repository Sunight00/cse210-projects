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
            Console.WriteLine("2. Reflecting Activuty.");
            Console.WriteLine("3. Listing Activity");
            Console.Write("Choose Activity: ");
            string option =Console.ReadLine();

            if (option == "1")
            {
                string name = "Breathing Activity";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                int duration = 0;
                Activity activity = new Activity(name,description,duration);
                Console.WriteLine();
                
                activity.DisplayStartingMessage();
                
            
                Console.Write("Time duration for your activity in seconds: ");
                string du = Console.ReadLine();
                Console.WriteLine();
                duration = int.Parse(du);

               
                Console.Clear();
                Console.WriteLine("Get ready....");
                activity.ShowSpinner(5);

                Console.WriteLine();
                BreathingActivity breathe = new BreathingActivity(name,description,duration);
                breathe.Run();
                
                Console.Clear();
                activity.DisplayEndingMessage();
                Console.WriteLine();
            }

            else if (option == "2")
            {
                string name = "Reflecting Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                int duration = 0;
                Activity activity = new Activity(name,description,duration);
                Console.WriteLine();
                
                activity.DisplayStartingMessage();
                
            
                Console.Write("Time duration for your activity in seconds: ");
                string du = Console.ReadLine();
                Console.WriteLine();
                duration = int.Parse(du);

               
                Console.Clear();

                ReflectingActivity reflectingActivity = new ReflectingActivity(name,description,duration);

                Console.Clear();
                Console.WriteLine("Get ready....");
                activity.ShowSpinner(5);

                Console.WriteLine("Consider The Following Prompt");
                Console.WriteLine();
                reflectingActivity.DisplayPrompt();
                Console.WriteLine();

                Console.WriteLine("When you have something in mind, press enter to continue");
                Console.ReadLine();
                //Thread.Sleep(1000);
                //reflectingActivity.DisplayQuestions();
                //Thread.Sleep(1000);
                Console.WriteLine("Now ponder on each of the following questions as they are related to this experience."); 
                Console.Write("You may begin in:");
                reflectingActivity.ShowCountDown(7);
                
                Console.Clear();
                reflectingActivity.DisplayQuestions();
                
                



                Console.Clear();
                activity.DisplayEndingMessage();
                Console.WriteLine();
                
            }
            else if (option == "3")
            {
                string name = "Listing Activity";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                int duration = 0;
                Activity activity = new Activity(name,description,duration);
                Console.WriteLine();
                
                activity.DisplayStartingMessage();
                
            
                Console.Write("Time duration for your activity in seconds: ");
                string du = Console.ReadLine();
                Console.WriteLine();
                duration = int.Parse(du);

               
                Console.Clear();
                Console.WriteLine("Get ready....");
                activity.ShowSpinner(5);

                Console.WriteLine();

                ListingActivity listingActivity = new ListingActivity();
                Console.WriteLine("List as many responses as you can to the following prompt.");
                Console.WriteLine(listingActivity.GetRandomPrompt());
                listingActivity.ShowCountDown(7);

                listingActivity.GetListFromUser();
            }
       } 
      
       

    }
}