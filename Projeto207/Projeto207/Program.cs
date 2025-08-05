using Projeto207.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;


namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");  //Entro com o caminho do arquivo
            string path = Console.ReadLine();  //Le o caminho e salva numa string

            List<Employee> list = new List<Employee>(); //Cria a lista 

            using (StreamReader sr = File.OpenText(path))  //Partindo daqui ate o fim do using e pra ler o arquivo linha por linha e instanciar nas variaveis corretas 
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] fields = line.Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name,email,salary));
                }
            }

            Console.Write("Enter salary threshold: ");  //Entra com o valor pra consulta nesse caso todos salarios maiores que o valor pedido 
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var r1 = list.Where(p => p.Salary >  value).OrderBy(p => p.Name).Select(p => p.Email);     // Usa linq pra concluir o exercicio
            Console.WriteLine("Email of people whose salary is more than " + value.ToString("F2") + ": ");

            foreach (var email in r1)
            {
                Console.WriteLine(email);
            }

            var sum = list.Where(p => p.Name.StartsWith('M')).Select(p => p.Salary).Sum();
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}