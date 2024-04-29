using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = Console.ReadLine().Split(' ');

            float N1 = float.Parse(abc[0]);
            float N2 = float.Parse(abc[1]);
            float N3 = float.Parse(abc[2]);

            double A = 0;
            double B = 0;
            double C = 0;

            if ( Math.Max(N1 , N2) > N3)
            {
                A = Math.Max(N1, N2);
                if (A > Math.Max(N2, N3))
                {
                    B = Math.Max(N2, N3);
                    C = Math.Min(N2, N3);
                }else
                {
                    B =Math.Max(N1, N3);
                    C = Math.Min(N1, N3);
                }
            }else
            {
                A = N3;
                B = Math.Max(N1, N2);
                C = Math.Min(N1, N2);
            }

            if( A >= B + C ){
                Console.WriteLine("NAO FORMA TRIANGULO");
            }else if( A*A == B*B + C*C)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }else if(A*A > B*B + C * C)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }else if (A*A < B*B + C * C)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            
            if (A == B && A == C && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }else if (A == B && A != C || A == C && A != B || B == C && B != A)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
            
        }
    }
}