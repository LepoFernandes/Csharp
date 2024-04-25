using System;
using System.Globalization;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] value = Console.ReadLine().Split(' ');

            int code = int.Parse(value[0]);
            int amount = int.Parse(value[1]);
            double price = 0;

            switch (code)
            {
                case 1 :
                    price = 4.00;
                    break;
                case 2 :
                    price = 4.50;
                    break;
                case 3 :
                    price = 5.00;
                    break;
                case 4 :
                    price = 2.00;
                    break;
                case 5 :
                    price = 1.50;
                    break;
                default :
                    Console.WriteLine("Codigo invalido");
                    break;
             }
                    double total = amount * price;

                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}