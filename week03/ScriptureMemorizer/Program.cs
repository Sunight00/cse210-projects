using System;

class Program
{
    static void Main(string[] args)
    {
        {
       
        Reference reference = new Reference("Genesis", 1, 3, 4);

        string scriptureText = "And God said, Let there be light: and there was light. And God saw the light, that it was good: and God divided the light from the darkness.";

      
        Scripture scripture = new Scripture(reference, scriptureText);

        Console.Clear();
        Console.WriteLine("Memorization Helper");
        Console.WriteLine("====================");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        // Main loop
        while (true)
        {
            Console.WriteLine("Press Enter to hide random words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            // Hide random words
            scripture.HideRandomWords(3); // Hide 3 random words at a time
            Console.Clear();

            // Display the updated scripture
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            // Check if the scripture is completely hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }
        }
    };
    }
}
