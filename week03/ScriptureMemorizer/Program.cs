using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        bool open = true;
        while (open)
        {   
            string response = Console.ReadLine();
            if (response !="quit")
            {
                
                Scripture n = new Scripture();
                n.HideWords();
                
                Console.WriteLine(n.GetDisplayText());
            }
        }*/
        //open = false;
        Word n = new Word();
        n.Hide();
        Console.WriteLine(n.GetDisplayText());
        
         
        

        
  
    }
}

