using System;
using System.Globalization;
using System.Collections.Generic;
using Projeto144;
using System.Diagnostics.SymbolStore;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Quantos empregados quer cadastrar?");
            int N = int.Parse(Console.ReadLine());

            List<Funcionario> listFuncionarios = new List<Funcionario>();

            for (int i = 0; i < N; i++) 
            {
                
                Console.Write("Qual id do funcionario: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Qual nome do funcionario: ");
                string name = Console.ReadLine();

                Console.Write("Qual salario do funcionario: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Funcionario X = new Funcionario(id, name, salary);

                listFuncionarios.Add(X); 

                Console.WriteLine("Adicionado com sucesso.");
                
                

            }

            Console.WriteLine("Escolha o funcionario que voce quer aumentar o salario: ");

            int codigo = int.Parse(Console.ReadLine());

            Funcionario funcionario = listFuncionarios.Find(x => x.Id == codigo);

            if (listFuncionarios != null)
            {
                Console.WriteLine("Qual o percentual: ");
                double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionario.AumentarSalario(percentual);
            } else
            {
                Console.WriteLine("Funcionario nao encontrado.");
            }

            foreach (Funcionario X in listFuncionarios)
            {
                Console.WriteLine(X.ToString());
            }
        }
    }
}