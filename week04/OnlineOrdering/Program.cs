using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("123 Center St", "Springbille", "UT", "USA");
        Customer customer1 = new Customer("Nely Crespin", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Candy", "1", 4, 1));
        order1.AddProduct(new Product("Chocolate", "2", 5, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.GetTotalCost():F2}\n");

    }
}