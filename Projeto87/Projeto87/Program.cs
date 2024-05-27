using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int x = 1, y = 0, z = 0;
            n = int.Parse(Console.ReadLine());
            
            if (n > 0 &&  n < 46 )
            {

                if (n == 1)
                {
                    Console.WriteLine("0 ");

                }else if (n == 2)
                {
                    Console.WriteLine("0 1");

                }else
                {
                    Console.Write("0 1");
                    for (int i = 3; i <= n; i++)
                    {
                        z = x + y;
                        Console.Write(" " + z);
                        y = x;
                        x = z;
                    }
                    Console.WriteLine();
                }                                    
            }                      
        }
    }
}
