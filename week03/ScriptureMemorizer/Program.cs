using System;

class Program
{
    static void Main(string[] args)
    {
        bool open = true;
        while (open)
        {   
            string response = Console.ReadLine();
            if (response !="quit")
            {
                Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
                Scripture n = new Scripture();
                n.HideWords();
                
                Console.WriteLine(n.GetDisplayText());
            }
        }
        open = false;
        
         
        

        
  
    }
}

