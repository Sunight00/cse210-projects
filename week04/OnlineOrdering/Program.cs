using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Product i = new Product("a","d",1,9);
        Product w = new Product("a","d",1,7);
        Order Orders = new Order();
        Orders.CalculateTotalOrder();
        

        Console.WriteLine(w.Total());
        Console.WriteLine(i.Total());
      
        Customer n = new Customer();
        Console.WriteLine(n._address.IsUsa());

         
    }
}