using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Product i = new Product("a","d",1,1);
        Product w = new Product("a","d",1,9);
        Order Orders = new Order();
        Console.WriteLine(Orders.CalculateTotalOrder());

        Console.WriteLine(w.Total());
      
        Customer n = new Customer();
        Console.WriteLine(n._address.IsUsa());

         
    }
}