using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address address = new Address("132 My Street","d","d","US");
        Product firstProduct = new Product("shoe", "1122", 1, 2);
        Product SecondProduct = new Product("broom", "5266", 1, 2);
        Product ThirdProduct = new Product("pen", "1223", 1, 2);

        //Console.WriteLine(address.InUsa());

        Order n = new Order(firstProduct,SecondProduct,ThirdProduct);
        Order cus = new Order("j",address);
        //Console.WriteLine(cus._customer.CheckUSA());
      
        // Assuming _firstProduct is a property or field, you can assign a value to it
                //n.ha();
                
        
              
        Customer add = new Customer("j",address);
        //add.CheckUSA();
        //Console.WriteLine(cus._customer.CheckUSA());
     
        Console.WriteLine(n.TotalOrder());

        Console.WriteLine(cus.shippingCost()+n.TotalOrder());
        //n.PackingLabel();
        //n.ShippingLabel();
        Console.WriteLine(address.address());

        n.PackingLabel();

    }
}