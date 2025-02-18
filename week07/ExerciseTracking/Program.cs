using System;

namespace Sport
{
    class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("4th Nov 2033",30,3);
        Console.WriteLine(run.GetSummary());
    Console.WriteLine();
        Cycling cycling = new Cycling("4th Nov 2033",30,12);
        Console.WriteLine(cycling.GetSummary());
    Console.WriteLine();
        Swimming swimming = new Swimming("4th Nov 2033",30,20);
        Console.WriteLine(swimming.GetSummary());
    
    }
}
}