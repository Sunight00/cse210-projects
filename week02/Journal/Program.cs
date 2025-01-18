using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program");
        Journal newJournal = new Journal();
        while(true)
        {
            Console.WriteLine("1.Create Entry");
            Console.WriteLine("2.Show Entries");
            Console.WriteLine("3.Save File");
            Console.WriteLine("4.Exit");
            Console.Write("Enter Your Selection: ");
            string response = Console.ReadLine();
            if (response== "1")
            {
                newJournal.AddEntry();
            }
            else if ( response == "2")
            {
                newJournal.DisplayAll();
            }
            else if ( response == "3")
            {
                Console.Write("Enter File Name: ");
                string file = Console.ReadLine();
                newJournal.SaveToFile(file);
            }
            else if (response == "4")
            {
                Console.Write("Enter File Name: ");
                string file = Console.ReadLine();
                newJournal.LoadFromFile(file);
            }



            Console.WriteLine("");
        }   
    }
   
}