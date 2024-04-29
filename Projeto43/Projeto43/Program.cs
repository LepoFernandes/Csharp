using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().Split(' ');

            int A = int.Parse(number[0]);
            int B = int.Parse(number[1]);

            if (B % A == 0 || A % B == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
