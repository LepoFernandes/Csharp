using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            // DEFININDO AS VARIAVEIS
            int N = int.Parse(Console.ReadLine());
            string[] nomes;
            int[] idades;
            double[] altura;
            int menores= 0;
            double porcentagem = 0.0;


            //INSTANCIANDO AS VARIAVEIS
            nomes = new string[N];
            idades = new int[N];
            altura = new double[N];


            //ENTRADA DOS DADOS
            for (int i = 0; i < N; i++) 
            {
                string[] gerais = Console.ReadLine().Split(' ');
                nomes[i] = gerais[0];
                idades[i] = int.Parse(gerais[1]);
                altura[i] = double.Parse(gerais[2], CultureInfo.InvariantCulture);
                
            }

            //SOMANDO AS ALTURAS E FAZENDO A MEDIA 
            double soma = 0.0;

            for (int i = 0;i < N; i++)
            {
                soma = soma + altura[i];
            }

            double media = 0.0;
            media = soma / N;


            //FAZENDO A PORCENTAGEM DE MENORES DE 16
            for (int i = 0;i < N ; i++)
            {
                if (idades[i] < 16)
                {
                     menores++;
                }
            }

            porcentagem = ((double)menores / N) * 100.0;

            Console.WriteLine("Altura media: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pessoas com menos de 16 anos : " + porcentagem.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}