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

        Order order = new Order(firstProduct,SecondProduct,ThirdProduct);
        Order cus = new Order("Fred Jackson",address);
        //Console.WriteLine(cus._customer.CheckUSA());
      
        // Assuming _firstProduct is a property or field, you can assign a value to it
                //n.ha();
                
        
        //Customer add = new Customer("Fred Jackson",address);
        //Console.Write(add.name());
        //add.CheckUSA();
        //Console.WriteLine(cus._customer.CheckUSA());
     
       
        //n.PackingLabel();
        //n.ShippingLabel();
        //Console.WriteLine(order.TotalOrder());
        order.PackingLabel();
        Console.WriteLine($"Total: ${cus.shippingCost()+order.TotalOrder()}");
        cus.ShippingLabel();

    
    }
}