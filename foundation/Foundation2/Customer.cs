public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsUSA()
    {
        return _address.IsUSA();
    }

    public override string ToString()
    {
        return $"{_name} - {_address}";
    }
}
