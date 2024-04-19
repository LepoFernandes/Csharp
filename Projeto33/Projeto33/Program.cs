using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] diaInicio = Console.ReadLine().Split(' ');
            string[] horaInicio = Console.ReadLine().Split(':');

            string[] diaFinal = Console.ReadLine().Split();
            string[] horaFinal = Console.ReadLine().Split(':');

            int diaI = int.Parse(diaInicio[1]);
            int inicioH = int.Parse(horaInicio[0]);
            int inicioM = int.Parse(horaInicio[1]);
            int inicioS = int.Parse(horaInicio[2]);

            int diaF = int.Parse(diaFinal[1]);
            int finalH = int.Parse(horaFinal[0]);
            int finalM = int.Parse(horaFinal[1]);
            int finalS = int.Parse(horaFinal[2]);

            int inicioTotalSeg = inicioS + (inicioM * 60) + (inicioH * 3600) + (diaI * 86400);
            int fimTotalSeg = finalS + (finalM * 60) + (finalH * 3600) + (diaF * 86400);
            int duracaoTotalSeg = fimTotalSeg - inicioTotalSeg;

            int dias = duracaoTotalSeg / 86400;
            int horas = (duracaoTotalSeg % 86400) / 3600;
            int minutos = ((duracaoTotalSeg % 86400) % 3600) / 60;
            int segundos = ((duracaoTotalSeg % 86400) % 3600) % 60;


            Console.WriteLine(dias + " dia(s)");
            Console.WriteLine(horas + " hora(s)");
            Console.WriteLine(minutos + " minuto(s)");
            Console.WriteLine(segundos + " segundo(s)");
        }
    }
}