using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
               
                string[] entradas = Console.ReadLine().Split(' ');

                int M = int.Parse(entradas[0]);
                int N = int.Parse(entradas[1]);
                

                
                if (M <= 0 || N <= 0)
                {
                    break;
                }

               
                int maior = M > N ? M : N;
                int menor = M < N ? M : N;

                int soma = 0;

              
                for (int i = menor; i <= maior; i++)
                {
                    Console.Write(i + " ");
                    soma += i;
                }

              
                Console.WriteLine("Sum=" + soma);
            }



        }
    }
}