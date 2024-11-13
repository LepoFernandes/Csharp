using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args) 
        {
            DateTime d = new DateTime(1999 , 9 , 8 , 17 ,30 , 36 , 600); 

            Console.WriteLine("Data: " + d.Date);
            Console.WriteLine("Dia: " + d.Day);
            Console.WriteLine("Dia da semana: " + d.DayOfWeek);
            Console.WriteLine("Dia do ano: " + d.DayOfYear);
            Console.WriteLine("Hora: " + d.Hour);
            Console.WriteLine("Kind: " + d.Kind);
            Console.WriteLine("Milisegundos: " + d.Millisecond);
            Console.WriteLine("Minutos: " + d.Minute);
            Console.WriteLine("Mes do ano: " + d.Month);
            Console.WriteLine("Segundos: " + d.Second);
            Console.WriteLine("Ticks: " + d.Ticks);
            Console.WriteLine("Horario do dia: " + d.TimeOfDay);
            Console.WriteLine("Ano: " + d.Year);
        }
    }
}