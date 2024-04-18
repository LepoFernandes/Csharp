using System;
using System.Globalization;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int quociente, resto, notas, moedas;

            resto = (int)(valor * 100 + 0.5);

            Console.WriteLine("NOTAS:");

            notas = 100;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ 100.00");
            resto = resto % (notas * 100);

            notas = 50;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ 50.00");
            resto = resto % (notas * 100);

            notas = 20;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ 20.00");
            resto = resto % (notas * 100);

            notas = 10;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ 10.00");
            resto = resto % (notas * 100);

            notas = 5;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ 5.00");
            resto = resto % (notas * 100);

            notas = 2;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ 2.00");
            resto = resto % (notas * 100);

            Console.WriteLine("MOEDAS:");

            moedas = 100;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto = resto % moedas;

            moedas = 50;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto = resto % moedas;

            moedas = 25;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto = resto % moedas;

            moedas = 10;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto = resto % moedas;

            moedas = 5;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto = resto % moedas;

            moedas = 1;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.01");
            Console.ReadLine();


        }
    }
}
