using System;
using System.Globalization;

namespace cursos
{
    class Program
    {
        static void Main(string[] args) {
        
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int room = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de algum produto:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu sobrenome, idade e altura (na mesma linha):");
            
            string[] vet = Console.ReadLine().Split(' ');
            string lastname = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine(name);
            Console.WriteLine(room);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastname);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}