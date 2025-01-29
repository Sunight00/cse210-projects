using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address lo = new Address("d","d","d","US");
        Product firstProduct = new Product("shoe", "exampleDescription", 1, 2);
        Product SecondProduct = new Product("broom", "exampleDescription", 1, 2);
        Product ThirdProduct = new Product("pen", "exampleDescription", 1, 2);

        Console.WriteLine(lo.InUsa());

        Order n = new Order(firstProduct,SecondProduct,ThirdProduct);
        Order cus = new Order("j",lo);
        Console.WriteLine(cus._customer.CheckUSA());
      
        // Assuming _firstProduct is a property or field, you can assign a value to it
                //n.ha();
                

              
        Customer add = new Customer("j",lo);
        //add.CheckUSA();
        //Console.WriteLine(cus._customer.CheckUSA());
     
        Console.WriteLine(n.TotalOrder());

        Console.WriteLine(cus.shippingCost()+n.TotalOrder());
        n.PackingLabel();g
        
        
    }
}