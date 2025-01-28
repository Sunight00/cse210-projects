using System.Net.Http.Headers;

public class Order
{
    private List<Product> _products = new List<Product>();
    private string _customer;
    private string _address;

    public Product prod = new Product();
    
  


    public Order()
    {

       
    }


    public string PackingLabel()
    {
        return "";
    }

     public string ShippingLabel()
    {
        return "";
    }



    public void CalculateTotalOrder()
    {   
        foreach (Product sum in _products)
        {
           Console.WriteLine($"{sum.Total()} jj");
             
        }
        
       
    }
}