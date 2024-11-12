using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2024, 11, 12);
            DateTime d2 = new DateTime(2024,11, 12, 14 ,52 , 25);

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            DateTime d3 = DateTime.Now;
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;
            

            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
        }
    }
}