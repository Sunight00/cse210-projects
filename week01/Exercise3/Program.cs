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

        while (guess !=magic)
        {        
            if (guess > magic)
            {
                Console.WriteLine("Lower");
             }
            else
            {
                Console.WriteLine("Higher");
            }
            Console.Write("What is your guess?");
            string newguess = Console.ReadLine();   
            guess = int.Parse(newguess);
        }
        if (guess == magic)
        {
            Console.WriteLine("You guessed it");
        }

    }
}