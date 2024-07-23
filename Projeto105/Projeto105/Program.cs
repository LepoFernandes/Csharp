using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //INICIANDO QUANTAS ENTRADAS

            int N = int.Parse(Console.ReadLine());

            //INICIANDO OS VETORES 

            string[] names = new string[N];
            double[] value1 = new double[N];
            double[] value2 = new double[N];
            double[] average = new double[N];
            
            //VARIAVEL PRA SABER QUANTOS APROVADOS
            int NumberApproved = 0;
            int index = 0;

            //LOOP PARA PEGAR AS ENTRADAS E COLOCAR NOS LUGARES CERTOS

            for (int i = 0; i < N; i++)
            {
                string[] entry = Console.ReadLine().Split(' ');
                names[i] = entry[0];
                value1[i] = double.Parse(entry[1] , CultureInfo.InvariantCulture);
                value2[i] = double.Parse(entry[2], CultureInfo.InvariantCulture);
                
            }
            
            //CALCULANDO A MEDIA

            for (int i = 0;i < N; i++)
            {
                average[i] = (value1[i] + value2[i]) / 2;
            }

            //SABER QUANTOS APROVADOS

            for (int i = 0; i < N; i++)
            {
                if (average[i] >= 6.0)
                {
                    NumberApproved++;
                }
            }

            //COLOCANDO O NOME DOS APROVADOS NO VETOR

            string[] approved = new string[NumberApproved];

            for (int i = 0; i < N; i++)
            {
                if (average[i] >= 6.0)
                {
                    approved[index] = names[i];
                    index++;
                }
            }

            foreach (string elements in approved)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
