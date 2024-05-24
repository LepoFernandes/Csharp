using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) 
            {
                Console.Write(i + " ");
                Console.Write(i * i + " ");
                Console.WriteLine(i * i * i);

                Console.Write(i + " ");
                Console.Write(i * i+1 + " ");
                Console.WriteLine(i * i * i+1);
            }
        }
    }
}