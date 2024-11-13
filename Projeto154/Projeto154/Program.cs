using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime x = new DateTime(1999, 9, 8, 17, 30, 49, 000);
            DateTime r = DateTime.Now;
           
            DateTime y = x.AddDays(2);
            DateTime a = x.AddHours(5);
            DateTime b = x.AddMilliseconds(352);
            DateTime c = x.AddMinutes(8);
            DateTime d = x.AddMonths(1);
            DateTime e = x.AddSeconds(25);
            
            DateTime f = x.AddYears(4);
            TimeSpan g = r.Subtract(x);



            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(r);
        }
    }
}