using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int countAlcool = 0;
            int countGasolina = 0;
            int countDiesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    countAlcool++;
                }
                else if (tipo == 2)
                {
                    countGasolina++;
                }
                else if (tipo == 3)
                {
                    countDiesel++;
                }
                
                    tipo = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + countAlcool);
            Console.WriteLine("Gasolina: " + countGasolina);
            Console.WriteLine("Diesel: " + countDiesel);

        }
    }
}