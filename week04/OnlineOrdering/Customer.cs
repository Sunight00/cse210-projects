using System.Text;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address address)
    {
        _name =name;
        _address=address;
    }
    
    
    public bool CheckUSA()
    {   
        return _address.InUsa();
    }

    public string name()
    {
        return _name;
    }
}