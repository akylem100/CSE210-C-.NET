public class Product
{
    private string _name;
    private int _productID;
    private int _quantity;
    private double _price;

    public Product(string name, int productID, int quantity, double price)
    {
        _name = name;
        _productID = productID;
        _quantity = quantity;
        _price = price;
    }

    public double getCost()
    {
        return _quantity * _price;
    }

    public override string ToString()
    {
        return $"{_name} | ID: {_productID}, Quantity: {_quantity}, Price: {_price:C}";
    }
}
