using System;

class Program
{
    static void Main(string[] args)
    {
        Reference p =new Reference();
        p.SetOneVerse("gen",1,3);
        p.GetDisplayText();
        
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine(p.GetDisplayText());


        Word hh = new Word();
        Console.WriteLine(hh.SetWord("And God said, Let there be light: and there was light."));

        
    }
}