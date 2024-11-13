using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args) 
        {
            DateTime d = new DateTime(1999, 9, 8, 17, 30, 36);

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            Console.WriteLine();

            string s5 = d.ToString();
            string s6 = d.ToString("yyyy - MM - dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine();

            long s8 = d.ToBinary();
            Console.WriteLine((long)s8);
        }
    }
}