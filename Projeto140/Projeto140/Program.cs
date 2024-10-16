using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            double[] A = new double[N];
            double average = 0.0;

            for (int i = 0; i < N; i++) 
            {
                A[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                average += A[i];
            }

            average = average / N;

            Console.WriteLine("Average Height = " + average.ToString("F2" , CultureInfo.InvariantCulture));

        }
    }
}