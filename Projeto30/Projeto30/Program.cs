using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            int v100 = 100;
            int resto100 = valor % v100;
            int n100 = valor / v100;

            int v50 = 50;
            int resto50 = resto100 % v50;
            int n50 = resto100 / v50;

            int v20 = 20;
            int resto20 = resto50 % v20;
            int n20 = resto50 / v20;

            int v10 = 10;
            int resto10 = resto20 % v10;
            int n10 = resto20 / v10;

            int v5 = 5;
            int resto5 = resto10 % v5;
            int n5 = resto10 / v5;

            int v2 = 2;
            int resto2 = resto5 % v2;
            int n2 = resto5 / v2;

            int v1 = 1;
            int resto1 = resto2 % v1;
            int n1 = resto2 / v1;

            Console.WriteLine(valor);
            Console.WriteLine(n100 + " nota(s) de R$ 100,00");
            Console.WriteLine(n50 + " nota(s) de R$ 50,00");
            Console.WriteLine(n20 + " nota(s) de R$ 20,00");
            Console.WriteLine(n10 + " nota(s) de R$ 10,00");
            Console.WriteLine(n5 + " nota(s) de R$ 5,00");
            Console.WriteLine(n2 + " nota(s) de R$ 2,00");
            Console.WriteLine(n1 + " nota(s) de R$ 1,00");
        }
    }
}