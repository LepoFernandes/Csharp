using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] num = Console.ReadLine().Split(' ');

            int A = int.Parse(num[0]);
            int B = int.Parse(num[1]);
            int C = int.Parse(num[2]);
            int D = int.Parse(num[3]);

            if (B > C && D > A && C + D > A + B && C <= 0 && D <= 0 && A % 2 != 0)
            {

                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}