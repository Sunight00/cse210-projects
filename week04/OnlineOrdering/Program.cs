using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Product name = new Product("q","q",2,3);
        Product q = new Product("q","q",2,3);

        Console.WriteLine(name.TotalCost());
    }
}