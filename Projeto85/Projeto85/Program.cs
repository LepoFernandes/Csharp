using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N > 1 && N < 1000)
            {

                int A = 1;

                for (; N > 0; N--)
                {
                    Console.Write(A + " ");
                    Console.Write(Math.Pow(A, 2) + " ");
                    Console.WriteLine(Math.Pow(A, 3));
                    A = A + 1;
                }
            }
        }
    }
}