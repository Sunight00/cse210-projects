using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Your Grade:");
        string g = Console.ReadLine();
        // converting g (grade) to integer
        int grade = int.Parse(g);

        if (grade>=90)
        {
            Console.WriteLine("A");
        }
        else if (grade>=80)
        {
            Console.WriteLine("B");
        }
    }
}