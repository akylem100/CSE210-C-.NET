using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("4458 Random St.", "Anaheim", "California", 90210, true);
        Address address2 = new Address("741 Redstone St", "Amsterdam", "Netherlands", 14452, false);

        Customer customer1 = new Customer("Jason McGuire", address1);
        Customer customer2 = new Customer("Brittlee Myers", address2);

        Product product1 = new Product("MSI Laptop", 389, 1, 1200.00);
        Product product2 = new Product("Razer Mouse", 1012, 2, 75.00);
        Product product3 = new Product("Samsung Monitor", 560, 1, 300.00);

        Console.WriteLine();

        Order order1 = new Order(customer1, "2024-10-02");
        order1.Products.Add(product1);
        order1.Products.Add(product2);
        order1.printReceipt();

        Console.WriteLine();

        Order order2 = new Order(customer2, "2024-10-09");
        order2.Products.Add(product3);
        order2.printReceipt();

        Console.WriteLine();
    }
}
