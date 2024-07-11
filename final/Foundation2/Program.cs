using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new("John Doe", address1);
        Order order1 = new(customer1);

        Product product1 = new("Widget", 10, 2);
        Product product2 = new("Gadget", 20, 1);
        Product product3 = new("Doohickey", 30, 1);

        order1.addProduct(product1);
        order1.addProduct(product2);
        order1.addProduct(product3);

        Address address2 = new("456 Elm St", "Anytown", "MI", "CA");
        Customer customer2 = new("Jane Smith", address2);
        Order order2 = new(customer2);

        Product product4 = new("Thingamajig", 40, 3);
        Product product5 = new("Whatchamacallit", 50, 2);
        Product product6 = new("Doodad", 60, 1);

        order2.addProduct(product4);
        order2.addProduct(product5);
        order2.addProduct(product6);

        List<Order> orders = new();
        orders.Add(order1);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine(order.getShippingLabel());
            Console.Write(order.getPackingLabel());
            Console.WriteLine($"Total: {order.getTotalPrice()}\n");
        }
    }
}