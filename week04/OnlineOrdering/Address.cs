public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
        _country="USA";
        _city="Henny";
        _state="dWWW";
        _street="dddd";
    }

    public bool IsUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        else{
            return false;
        }
    }

    public string CustomerAddress()
    {
        return $"{_street},{_city},{_state},{_country}";
    }
}