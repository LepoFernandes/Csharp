using System;
using Projeto205.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(){Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product(){Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product(){Id = 3, Name = "Tv", Price = 1700.0, Category = c3},
                new Product(){Id = 4, Name = "Notebook", Price = 1300.0, Category = c2},
                new Product(){Id = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product(){Id = 6, Name = "Tablet", Price = 700.0, Category = c2},
                new Product(){Id = 7, Name = "Camera", Price = 700.0, Category = c3},
                new Product(){Id = 8, Name = "Printer", Price = 350.0, Category = c3},
                new Product(){Id = 9, Name = "MacBook", Price = 1800.0, Category = c2},
                new Product(){Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product(){Id = 11, Name = "Level", Price = 70.0, Category = c1}
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0); //Seleciona os produtos de tier 1 e com precos menores que 900.
            Print("TIER 1 AND PRICE < 900.0: ", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name); //Seleciona apenas o nome dos produtos da categoria ferramenta.
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            var r3 = products.Where(p => p.Name.StartsWith('C')).Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); // Seleciona os produtos que iniciam com C, no caso do Category.Name por haver ambiguidade ce da um apelido antes.
            Print("PRODUCTS STARTING WITH 'C'", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name); //Seleciona os produtos de tier um e depois ordena primeiro por preco e depois por nome.
            Print("PRODUCTS TIER 1, ORDER BY PRICE THEN BY NAME", r4);

            var r5 = r4.Skip(2).Take(4); // Pega os elementos do r4 e cria um r5 pulando os 2 primeiros e pegando os proximos 4.
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = products.First();
            Console.WriteLine("FIRST TEST 1: " + r6); //Pega o primeiro da lista

            /*Da erro pq nao existe ngm e nao pode usar o first em lista vazia mas pode fazer o exemplo abaixo
            var r7 = products.Where(p => p.Price > 3000.0).First();
            Console.WriteLine("FIRST TEST 2: " + r7); */

            var r8 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            if (r8 == null)
            {
                Console.WriteLine("FIRST TEST 2: NULL");
            }
            else
            {
                Console.WriteLine("FIRST TEST 2: " + r8);
            }

            Console.WriteLine();

            var r9 = products.Where(p => p.Id == 3).SingleOrDefault(); //Proximos exemplos sao pareciso com o de FirstOrDefault
            Console.WriteLine("SINGLE OR DEFAULT TEST 1:" + r9);
            Console.WriteLine();

            var r10 = products.Where(p => p.Id == 30).SingleOrDefault();
            if (r10 != null)
            {
                Console.WriteLine("SINGLE OR DEFAULT TEST 1:" + r10);
            }
            else
            {
                Console.WriteLine("NULL");
            }

            var r11 = products.Max(p => p.Price);
            Console.WriteLine("Max price : " + r11.ToString("F2", CultureInfo.InvariantCulture)); //Maior preco

            var r12 = products.Min(p => p.Price);
            Console.WriteLine("Min price : " + r12.ToString("F2", CultureInfo.InvariantCulture)); //Menor preco

            var r13 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("CATEGORY 1 SUM PRICES : " + r13.ToString("F2", CultureInfo.InvariantCulture));

            var r14 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);   //Nesse caso se a colecao estiver vazia vai dar um erro por isso a r15 tem uma forma de corrigir se for vazia fica zero
            Console.WriteLine("CATEGORY 1 AVERAGE PRICES: " + r14.ToString("F2", CultureInfo.InvariantCulture));

            var r15 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); // Calcula a media cuidando o possivel erro da anterior
            Console.WriteLine("CATEGORY 5 AVERAGE PRICES: " + r15.ToString("F2", CultureInfo.InvariantCulture));

            var r16 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x , y) => x + y);  //Criando uma operacao que eu quiser usando o aggregate nesse caso uma soma mas posso colocar qualquer operacao que quiser
            Console.WriteLine("CATEGORY 1 AGGREGATE SUM: " + r16.ToString("F2", CultureInfo.InvariantCulture)); //Pra tratar um possivel erro caso esteja vazia faz da seguinte forma : .Aggregate(0.0, (x , y) => x + y);

            Console.WriteLine();

            var r17 = products.GroupBy(p => p.Category);
            foreach ( IGrouping<Category, Product> group in r17)
            {
                Console.WriteLine("CATEGORY : " + group.Key.Name + " : ");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}