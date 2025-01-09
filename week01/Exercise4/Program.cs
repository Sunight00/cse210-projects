using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        //created a list for user input
        Console.Write("Enter a number: ");
        string value = Console.ReadLine();
        int number = int.Parse(value);
        numbers.Add(number);
    }
}