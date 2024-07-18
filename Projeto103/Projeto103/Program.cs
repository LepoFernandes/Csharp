using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] entradas = new int[N];
            int count = 0;
           
            
            // ENTRANDO COM OS NUMEROS

            for (int i = 0; i < N; i++)
            {
                entradas[i] = int.Parse(Console.ReadLine());
            }

            //DESCOBRINDO QUANTOS PARES

            for (int i = 0;i < N; i++)
            {
                if (entradas[i] % 2 == 0)
                {
                    count++;
                }
            }
            
            //CRIANDO O VETOR PARES JA SABENDO QUANTOS ELEMENTOS VAO TER

            int[] pares = new int[count];
            int index = 0;

            for (int i = 0;i < N ; i++)
            {
                if (entradas[i] % 2 == 0)
                {
                    pares[index] = entradas[i];
                    index++;
                }
            }

            //FAZENDO A MEDIA ARITMETICA

            int soma = 0;

            for(int i = 0;i < pares.Length ; i++)
            {
                soma = soma + pares[i];
            }

            double media = 0.0;

            media = (double) soma / count;

            Console.WriteLine("MEDIA : " +  media.ToString("F1", CultureInfo.InvariantCulture)); 
        }
    }
}
