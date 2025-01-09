using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?");
        string magicNumber = Console.ReadLine();
        int magic = int.Parse(magicNumber);
        Console.Write("What is your guess?");
        string guesses = Console.ReadLine();
        int guess = int.Parse(guesses);

    }
}