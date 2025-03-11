using Projeto162.Entities;
using Projeto162.Entities.Enums;
using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            StatusCliente status = StatusCliente.Ativo;
            Console.WriteLine("Status do cliente: " + status);
            

            Cliente cliente = new Cliente(id, nome, email, status);

            Console.WriteLine("Entre com os dados do empréstimo:");
            DateTime data = DateTime.Now;
            Console.WriteLine("Data (DD/MM/YYYY): " + data);
            

            Console.WriteLine("Quantos livros desejar pegar?");

            int N = int.Parse(Console.ReadLine());

            Emprestimo emprestimo = new Emprestimo(data, Status.Pendente, cliente);

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Entre com os dados do livro #{i}:");
                Console.Write("Título: ");
                string titulo = Console.ReadLine();
                Console.Write("Autor: ");
                string autor = Console.ReadLine();
                Console.Write("Ano: ");
                string ano = Console.ReadLine();

                Livro livro = new Livro(titulo, autor, ano);
                
                emprestimo.AdicionarLivro(livro);
            }

            Console.WriteLine(emprestimo.ToString());
        }
    }
}