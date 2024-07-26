using System;
using System.Globalization;

namespace curso
{
     class Program
    {
        static void Main(string[] args)
        {
            //ENTRANDO COM O TOTAL

            int N = int.Parse(Console.ReadLine());

            string[] entradas = new string[N];

            //ENTRANDO COM OS DADOS NOS VETORES

            double[] alturas = new double[N];
            string[] sexo = new string[N];
            

            for (int i = 0;i < N; i++)
            {
                entradas = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(entradas[0], CultureInfo.InvariantCulture);
                sexo[i] = entradas[1];
            }

            //DESCOBRINDO A MAIOR E MENOR ALTURA

            double maior = alturas[0];
            double menor = alturas[0];

            for (int i = 0;i < alturas.Length; i++)
            {
                if (alturas[i] > maior)
                {
                    maior = alturas[i];
                }
            }

            for (int i = 0;i < alturas.Length ; i++)
            {
                if (alturas[i] < menor)
                {
                    menor = alturas[i];
                }
            }

            //FAZENDO A MEDIA DAS MULHERES

            double soma = 0.0;
            int countF = 0;

            for ( int i = 0;i < N ; i++)
            {
                if (sexo[i] == "F")
                {
                    countF++;
                    soma += alturas[i];
                }
            }

            double media = soma / countF;

            //QUANTOS HOMENS

            int countM = 0;

            for ( int i = 0; i < N ; i++)
            {
                if (sexo[i] == "M")
                {
                    countM++;
                }
            }


            Console.WriteLine("Menor Altura: " + menor);
            Console.WriteLine("Maior Altura: " + maior);
            Console.WriteLine("Media das alturas femininas: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens: " + countM);
        }
    }
}