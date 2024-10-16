using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null;

            double? y = null;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);


        }
    }
}