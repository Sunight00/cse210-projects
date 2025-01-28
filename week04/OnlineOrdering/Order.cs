public class Order
{
    private List<Product> _products = new List<Product>();
    public Customer _customer;


    public Order (Product q,Product w,Product e)
    {
        _products.Add(q);
        _products.Add(w);
        _products.Add(e);
    }




    /*public void ha()
    {
        foreach(Product n in _products)
        {
            Console.WriteLine(n.TotalCost());
        }
    }*/



    public double TotalOrder()
    {   
        double sum = 0;
        foreach(Product n in _products)
        {
            sum+=n.TotalCost();
        }
        if (_customer.CheckUSA() == true)
        {
             return sum +3;
        }
        else
        {
            return sum;
        }
       
    }

    public string PackingLabel()
    {
        return "your purchase";
    }

    public string ShippingLabel()
    {
        return "your delivery";
    }





}