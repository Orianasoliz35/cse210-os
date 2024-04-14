//Final Project - foundation 4, encapsulation:
using System;
using System.Collections.Generic;
using System.Linq;

class Program
    {
        static void Main(string[] args)
        {
            var address1 = new Address("123 Main St", "Anytown", "CA", "USA");
            var address2 = new Address("456 Elm St", "Othercity", "NY", "Canada");

            var customer1 = new Customer("John Doe", address1);
            var customer2 = new Customer("Jane Smith", address2);

            var product1 = new Product("Widget", 101, 3.50, 5);
            var product2 = new Product("Gadget", 102, 2.75, 3);
            var product3 = new Product("Doodad", 103, 1.20, 10);

            var order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            var order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            Console.WriteLine("Order 1 Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("\nOrder 1 Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"\nOrder 1 Total Price: ${order1.CalculateTotalCost():F2}");

            Console.WriteLine("\nOrder 2 Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("\nOrder 2 Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"\nOrder 2 Total Price: ${order2.CalculateTotalCost():F2}");
        }
    }
}