using System;

namespace Sport
{
    class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("4th Nov 2033",1,22);
        Console.WriteLine(run.GetSummary());
    }
}
}