using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.Parse("1999-09-08");
            DateTime d2 = DateTime.Parse("1999-09-08 17:30:45");

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            DateTime d3 = DateTime.Parse("08/09/1999");
            DateTime d4 = DateTime.Parse("08/09/1999 17:30:45");

            Console.WriteLine(d3);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.ParseExact("1999-09-08", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d6 = DateTime.ParseExact("08/09/1999 17:30:24" , "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture) ;

            Console.WriteLine(d5);
            Console.WriteLine(d6);
        }
    }
}