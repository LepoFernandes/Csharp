using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int A = 1;

            for (; N > 0 ; N--)
            {
                Console.Write(A + " ");
                Console.Write(A+1 + " ");
                Console.WriteLine(A+2 + " PUM");
                A = A + 4;
            }
       
        }
    }
}