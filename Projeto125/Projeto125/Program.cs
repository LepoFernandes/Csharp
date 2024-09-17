using Projeto125;
using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)     
        {
            Produto p = new Produto();


            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado: ");

            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite o numero de produtos a ser removido: ");

            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p );





        }
    }
}
