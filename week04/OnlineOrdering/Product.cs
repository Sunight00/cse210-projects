public class Product
{
    private string _productName;
    private string _productId;
    private double _productprice;
    private double _productQuantity;

    public double Total()
    {
        double total = _productprice * _productQuantity;
        return total;
    }
}