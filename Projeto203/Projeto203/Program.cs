using System;
using Projeto203.Entities;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(func).ToList();


            foreach(Product product in list)
            {
                Console.WriteLine(product.ToString());
            }

            Console.WriteLine();

            foreach (String p in result)
            {
                Console.WriteLine(p);
            }
        }

            
    }
}