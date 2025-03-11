using Projeto162.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto162.Entities;
using System.Net.Http.Json;

namespace Projeto162.Entities
{
    class Emprestimo
    {
        public DateTime Data { get; set; }
        public Status Status { get; set; }
        public List<Livro> Livros { get; set; } = new List<Livro>();
        public Cliente Cliente { get; set; }



        public Emprestimo()
        {
        }

        public Emprestimo(DateTime data, Status status, Cliente cliente)
        {
            Data = data;
            Status = status;
            Cliente = cliente;
        }


        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void RemoverLivro(Livro livro)
        {
            Livros.Remove(livro);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cliente: " + Cliente.Nome);
            sb.AppendLine("Email: " + Cliente.Email);
            sb.AppendLine("ID: " + Cliente.ID);

            sb.AppendLine("Data do empréstimo: " + Data.ToString("dd/MM/yyyy"));
            sb.AppendLine("Status do empréstimo: " + Status);
            sb.AppendLine("Livros emprestados:");
            foreach (Livro livro in Livros)
            {
                sb.AppendLine(livro.ToString());
            }
            return sb.ToString();
        }
    }
}
