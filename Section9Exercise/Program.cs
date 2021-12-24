using System;
using Section9Exercise.Entities;
using Section9Exercise.Entities.Enum;
using System.Globalization;

namespace Section9Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine();
            Console.WriteLine("Enter Order data: ");
            Console.Write("Status: ");
            OrderStatus ordeStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int orderQuantity = int.Parse(Console.ReadLine());
            DateTime moment = DateTime.Now;

            Order order = new Order(moment, ordeStatus, client);
            Console.WriteLine();


            for (int i = 0; i < orderQuantity; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, product);
                order.AddItem(orderItem);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order);

        }
    }
}
