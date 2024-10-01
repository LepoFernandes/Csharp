using Projeto136;
using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV" , 500.00 , 10);

            p.SetNome("TELEVISAO");

            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetNome());
        }
    }
}