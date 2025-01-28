using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Product firstProduct = new Product("exampleName", "exampleDescription", 1, 2);
        Product SecondProduct = new Product("exampleName", "exampleDescription", 1, 2);
        Product ThirdProduct = new Product("exampleName", "exampleDescription", 1, 2);

        Order n = new Order(firstProduct,SecondProduct,ThirdProduct);
      
        // Assuming _firstProduct is a property or field, you can assign a value to it
                //n.ha();
                

              
        
     

        Console.WriteLine(n.TotalOrder());

    }
}