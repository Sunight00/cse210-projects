using System;

class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
            Scripture n = new Scripture();
            n.HideWords();
            Console.WriteLine(n.GetDisplayText());
        }
        //string response = Console.Readline();
         
        

        
  
    }
}

