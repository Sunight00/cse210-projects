public class Order
{
    private List<string> _products = new List<string>();
    private string _customer;

    public Order()
    {
        _customer = "Jerry";
        _products=["Liquid Detergent","Broom","Bust Pan"];

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

    }
}