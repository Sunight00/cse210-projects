using System;

class Program
{
    static void Main(string[] args)
    {   PromptGenerator prompt = new PromptGenerator();
        string _promptText=prompt.GetRandomPrompt();
        Console.WriteLine(_promptText);


         string response = Console.ReadLine();

        Entry newEntry = new Entry();
        
       
        newEntry._entryText=response;
    }
}newEntry.Display();