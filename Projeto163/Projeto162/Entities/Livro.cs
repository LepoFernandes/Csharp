using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto162.Entities
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }


        public Livro()
        {
        }

        public Livro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Autor: {Autor}, Ano: {Ano}";
        }
    }
}
