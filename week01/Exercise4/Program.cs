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
        double average=0;
        // I previously chose int for average but it wasn't displaying the decimal points
        foreach (int num in numbers)
        {
            sum += num;
            /*average = sum / numbers.Count;
            this wasn't display decimal point*/
           average = numbers.Average();
        }
        List<int> positiveNumbers = new List<int>();
        //created list for positive numbers
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                positiveNumbers.Add(num);
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is : {average}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
        Console.WriteLine($"The smallest number is: {numbers.Min()}");
   
    }
}