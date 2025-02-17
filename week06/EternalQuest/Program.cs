using System;
using Goal;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.DisplayPlayerInfo();

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goal");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the options: ");
            string option = Console.ReadLine();

            Console.WriteLine();
            if (option == "1")
            {
                Console.WriteLine("The Types Of Goal Are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Gaol");
                Console.Write("What type of goal would you love to create: ");
                goalManager.CreateGoal();
            }
            else if (option =="2")
            {
                goalManager.ListGoalDetails();
            }
            else if (option =="3")
            {
                goalManager.SaveGoals();
            }



        }
    }
}