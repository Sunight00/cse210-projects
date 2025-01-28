using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Customer n = new Customer();
        Console.WriteLine(n._address.IsUsa());
    }
}