using System.Net.Http.Headers;

public class Order
{
    private List<string> _products = new List<string>();
    private string _customer;
    private string _address;

    public Product prod = new Product();


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