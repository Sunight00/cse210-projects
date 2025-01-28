public class Product
{
    private string _productName;
    private string _productId;
    private double _productprice;
    private double _productQuantity;

    public Product ()
    {
        
    }
    public Product(string name, string id, double price, double qty)
    {
        _productName = name;
        _productId= id;
        _productprice = price;
        _productQuantity = qty;
    }

    public double Total()
    {
        double total = _productprice * _productQuantity;
        return total;
    }
}