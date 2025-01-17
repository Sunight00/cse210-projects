using System;

class Program
{
    static void Main(string[] args)
    {   PromptGenerator prompt = new PromptGenerator();
        string _prompt=prompt.GetRandomPrompt();
        Console.WriteLine(_prompt);
        
        Entry newEntry = new Entry();
        string response = Console.ReadLine();
        newEntry._entryText=response;
        newEntry._promptText=_prompt;
        newEntry.Display();
       
    }
}