using System;


namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');          
            int horaInicial = int.Parse(entrada[0]);
            int minutoInicial = int.Parse(entrada[1]);
            int horaFinal = int.Parse(entrada[2]);
            int minutoFinal = int.Parse(entrada[3]);
            int totalMinutosI = (horaInicial * 60) + minutoInicial;
            int totalMinutosF = (horaFinal * 60) + minutoFinal;
            int duracao;


            if (totalMinutosI < totalMinutosF)
            {
                duracao = totalMinutosF - totalMinutosI;
            }
            else if (totalMinutosI > totalMinutosF)
            {
                duracao = (24 * 60 - totalMinutosI) + totalMinutosF;
            }
            else 
            {
                duracao = 24 * 60;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;


            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}