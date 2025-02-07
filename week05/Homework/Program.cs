using System;

namespace math 
{
    class Program
{
    static void Main(string[] args)
    {
        WritingAssignment assign =new  WritingAssignment("Alain","Subtraction","hahaha i tring dhhdh hdddd");

        Console.WriteLine(assign.GetString());
        Console.WriteLine($"{assign.GetWritingInformation()}");
    }
}
}