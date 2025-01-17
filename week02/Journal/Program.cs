using System;

class Program
{
    static void Main(string[] args)
    {   PromptGenerator prompt = new PromptGenerator();
        string _promptText=prompt.GetRandomPrompt();
        Console.WriteLine(_promptText);
        Entry newEntry = new Entry();
        string response = Console.ReadLine();
        newEntry._entryText=response;
        newEntry.Display();
       
    }
}