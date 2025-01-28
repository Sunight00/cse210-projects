public class Order
{
    private List<Product> _products = new List<Product>();
    //private string _customer;

    public Product _firstProduct;

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
    {   double sum = 0;
        foreach(Product n in _products)
        {
            sum+=n.TotalCost();
        }
        return sum;
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