using System.Net.Http.Headers;

public class Order
{
    private List<Product> _products = new List<Product>();
    private string _customer;
    private string _address;

    public Order()
    {
        Product p1 = new Product(); 
         _products.Add(p1);
        Product p2 = new Product();
        _products.Add(p2);
       
    }


    public string PackingLabel()
    {
        return "";
    }

     public string ShippingLabel()
    {
        return "";
    }



    public double CalculateTotalOrder()
    {
        return 0;
    }
}