public class Customer
{
    private string _name;
    public Address _address;

    public Customer (string name, Address address)
    {
        _name =name;
        _address=address;
    }
    
    public bool CheckUSA()
    {   
        return _address.InUsa();
    }
}