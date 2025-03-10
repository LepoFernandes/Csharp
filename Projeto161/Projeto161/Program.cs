using Projeto161.Entities;
using Projeto161.Entities.Enums;
using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name:");
            string nameClient = Console.ReadLine();

            Console.Write("Email:");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY) : ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            Client client = new Client(nameClient,email,birthday);

            Console.WriteLine("Enter order data:");
            Console.WriteLine("Status: " + OrderStatus.Processing);
            Console.WriteLine("How many items to this order?");

            int N = int.Parse(Console.ReadLine());

            Order order = new Order();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");

                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product produto1 = new Product(nameProduct, price);


                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderN = new OrderItem(quantity, price, produto1);

                order.AddItem(orderN);
                
            }

            Console.WriteLine(order.ToString());
        }
    }
}