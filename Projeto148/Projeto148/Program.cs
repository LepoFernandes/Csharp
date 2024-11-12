using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2024, 11, 12);
            DateTime d2 = new DateTime(2024,11, 12, 14 ,52 , 25);

            Console.WriteLine(d1); //Data com os parametros que passei
            Console.WriteLine(d2); //Data tbm com os parametros

            DateTime d3 = DateTime.Now;
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;
            

            Console.WriteLine(d3); //Data de agora com dia e horario
            Console.WriteLine(d4); //Data de hoje mas no horario zerado
            Console.WriteLine(d5); //Data de hoje com horario gmt 
        }
    }
}