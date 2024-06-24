using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] B;
            int N = int.Parse(Console.ReadLine());
            
            B = new double[N];


            for (int i = 0; i < N; i++)
            {
                B[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0;i < N; i++)
            {
                Console.WriteLine(B[i].ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
