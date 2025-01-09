using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        //Above created a list for user input
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        string value = Console.ReadLine();
        int number = int.Parse(value);
        // Above coverted the input to an int

        while (number !=0)
        {
            numbers.Add(number);
            Console.Write("Enter a number: ");
            value = Console.ReadLine();
            number = int.Parse(value);
        }
        //Above is a loop that end when 0 is inputed and it appends other figures to list
        int sum=0;
        int average=0;
        foreach (int num in numbers)
        {
            sum += num;
            average = sum / numbers.Count;
        }
        Console.WriteLine($"Sum is {sum}");
        Console.WriteLine($"Sum is {average}");
        Console.WriteLine($"Average {numbers.max()}")
        
    }
}