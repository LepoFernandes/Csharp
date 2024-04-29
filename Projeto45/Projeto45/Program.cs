using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] horas = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(horas[0]);
            int horaFinal = int.Parse(horas[1]);

            int duracao;

            if (horaFinal > horaInicial)
            {
                duracao = horaFinal - horaInicial;

            }else if (horaFinal == horaInicial )
            {
                duracao = 24;

            }else
            {
                duracao = (24 - horaInicial) + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " +  duracao + " HORA(S)");
        }
    }
}