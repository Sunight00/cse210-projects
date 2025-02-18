using System;

namespace Sport
{
    class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("4th Nov 2033",30,3);
        Console.WriteLine(run.GetSummary());

        Cycling cycling = new Cycling("4th Nov 2033",30,3);
        Console.WriteLine(cycling.GetSummary());
    }
}
}