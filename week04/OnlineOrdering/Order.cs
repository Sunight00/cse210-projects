public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Address _address;


    public Order (Product q,Product w,Product e)
    {
        _products.Add(q);
        _products.Add(w);
        _products.Add(e);
    }
    public Order (string a, Address d)
    {
        _customer=new Customer(a,d);
        _address= d;
    }

    //public Order ()






    //public Order ( )

    /*public void ha()
    {
        foreach(Product n in _products)
        {
            Console.WriteLine(n.TotalCost());
        }
    }*/


    //for suming the total of a order
    public double TotalOrder()
    {   
        double sum = 0;
        foreach(Product n in _products)
        {
            sum+=n.TotalCost();  
        }
        return sum;
        /*if (_customer.CheckUSA() ==  true)
        {
            return sum+=5;
        }
        else
        {
            return sum+=35;
        }*/ 
    }

    //for determinig shipping cost
    public double shippingCost()
    {   
        double sum=0;
            if (_customer.CheckUSA() ==  true)
        {
            return sum+=5;
        }
        else
        {
            return sum+=35;
        }
    }




    public void PackingLabel()
    {   
        foreach(Product n in _products)
        {
            Console.WriteLine(n.Display());
        }
        /*
        for (int i=0; i<_products.Count(); i++)
        {
            Console.WriteLine( _products[i]);
        }*/
    }

    public void ShippingLabel()
    {
       Console.WriteLine($"{_customer.name()},{_address.address()}" );
       
    }





}