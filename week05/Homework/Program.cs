using System;

class Program
{
    static void Main(string[] args)
    {
        static void welcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string name()
        {
            Console.Write("Please enter your name: ");
            string user = Console.ReadLine();
            return user;
        }
        static int number()
        {
            Console.Write("Please enter your favorite number: ");
            int favnum = int.Parse(Console.ReadLine()); // played around with this line to get it to work
            return favnum;
        }
        static void result(string user, int favnum)
        {
            int square = favnum*favnum;
            Console.WriteLine($"{user}, the square of your number is {square} .");
        }
        welcome();
        string person =name();
        int num = number();
        result(person, num);
    }
}