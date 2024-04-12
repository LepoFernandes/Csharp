using System;


namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());

            int tempo = distancia * 2;

            Console.WriteLine(tempo + " minutos");
        }
    }
}
