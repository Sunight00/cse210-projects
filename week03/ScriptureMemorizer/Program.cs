using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        
        

       
        Scripture n = new Scripture();
         n.HideWords();
        Console.WriteLine(n.GetDisplayText());
        

        
  
    }
}