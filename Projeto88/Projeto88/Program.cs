using System; 

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int fat = 1;
            

            if ( N > 0 && N < 13 )
            {
                for ( int i = N; i > 0 ; i-- )
                {
                    fat *= i;
                    
                }

                Console.WriteLine(fat);
            }
        }
    }
}