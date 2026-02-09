using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address(
            "127 Main Street",
            "Florida",
            "FL",
            "USA"
        );

        Customer customer1 = new Customer("Isaac Ihoon", usaAddress);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 900, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25, 2));

        Address nigeriaAddress = new Address(
            "47 Allen Avenue",
            "Abuja",
            "Abuja",
            "Nigeria"
        );

        Customer customer2 = new Customer("Bridget Johnson", nigeriaAddress);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P2001", 600, 1));
        order2.AddProduct(new Product("Charger", "P2002", 30, 2));
        order2.AddProduct(new Product("Earbuds", "P2003", 50, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");
        Console.WriteLine("-----------------------------------");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
