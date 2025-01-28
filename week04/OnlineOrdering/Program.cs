using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address lo = new Address("d","d","d","USA");
        Product firstProduct = new Product("shoe", "exampleDescription", 1, 2);
        Product SecondProduct = new Product("broom", "exampleDescription", 1, 2);
        Product ThirdProduct = new Product("pen", "exampleDescription", 1, 2);

        Console.WriteLine(lo.InUsa());

        Order n = new Order(firstProduct,SecondProduct,ThirdProduct);
      
        // Assuming _firstProduct is a property or field, you can assign a value to it
                //n.ha();
                

              
        
     

        Console.WriteLine(n.TotalOrder());

    }
}