using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int numbers = int.Parse(Console.ReadLine());   

                if (numbers == 0)
                {
                    Console.WriteLine("NULL");
                }
                if (numbers % 2 == 0 && numbers > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");

                }if (numbers % 2 == 0 && numbers < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");

                }else if(numbers % 2 != 0 && numbers >= 1)
                {
                    Console.WriteLine("ODD POSITIVE");

                }else if(numbers % 2 != 0 && numbers < 1)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                    
                
            }
        }
    }
}