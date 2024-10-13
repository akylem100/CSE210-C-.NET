public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _zip;
    private bool _isUSA;

    public Address(string street, string city, string state, int zip, bool isUSA)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        _isUSA = isUSA;
    }

    public bool IsUSA()
    {
        return _isUSA;
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state} {_zip}";
    }
}
