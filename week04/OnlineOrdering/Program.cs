using System;

class Program
{
    static void Main(string[] args)
    { 
        Address address = new Address("123 Main Street", "Los Angeles", "California", "USA");
        Customer customer1 = new Customer("Jhon", address);

        Order order = new Order(customer1);
        Product product1 = new Product("Mouse", 1001, 29.99f, 2);
        Product product2 = new Product("Keyboard", 1002, 79.50f, 1);
        order.AddProduct(product1);
        order.AddProduct(product2);
        
        string packing = order.CreatePackingLabel();
        string shipping = order.CreateShippingLabel();
        float totalCost = order.CalculateTotalCost();
        Console.Write($"{packing}");
        Console.WriteLine($"{shipping}");    
        Console.WriteLine($"{totalCost:F2}");  

        Console.WriteLine("");
        // ORDER 2

        Address address2 = new Address("456 Maple Street", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Mike", address2);

        Order order2 = new Order(customer2);

        Product product3 = new Product("Headset", 1003, 45.00f, 1);
        Product product4 = new Product("Webcam", 1004, 59.99f, 2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        string packing2 = order2.CreatePackingLabel();
        string shipping2 = order2.CreateShippingLabel();
        float totalCost2 = order2.CalculateTotalCost();

        Console.Write($"{packing2}");
        Console.WriteLine($"{shipping2}");
        Console.WriteLine($"{totalCost2:F2}");

    }
}