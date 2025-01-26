using System;

class Program
{
    static void Main(string[] args)
    {
        string reespone ="";
        while ( string response=="quit")
        {
            Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
            Scripture n = new Scripture();
            n.HideWords();
            Console.WriteLine(n.GetDisplayText());
        }
        string response = Console.Readline();
         
        

        
  
    }
}

