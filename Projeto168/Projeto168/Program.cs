using Projeto168.Entities;
using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commom, used or imported?");

                char resposta = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resposta == 'c')
                {
                    Product product = new Product(name, price);
                    products.Add(product);

                }
                else if (resposta == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    Product product = new UsedProduct(date, name, price);
                    products.Add(product);

                }
                else if (resposta == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product product = new ImportedProduct(customsfee, name, price);
                    products.Add(product);
                }

            }

            foreach (var product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}