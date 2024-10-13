public class Order
{
    public List<Product> Products { get; set; }
    private Customer _customer;
    private string _date;

    public Order(Customer customer, string date)
    {
        _customer = customer;
        _date = date;
        Products = new List<Product>();
    }

    public double getTotal()
    {
        double total = 0;
        foreach (Product product in Products)
        {
            total += product.getCost();
        }

        if (_customer.IsUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public void printReceipt()
    {
        Console.WriteLine($"Customer: {_customer}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine("Products:");
        foreach (Product product in Products)
        {
            Console.WriteLine(product.ToString());
        }
        Console.WriteLine($"Total: ${getTotal()} (Including shipping)");
    }
}
