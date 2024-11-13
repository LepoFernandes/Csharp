using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan t1 = new TimeSpan(); //zerado
            TimeSpan t2 = new TimeSpan(900000000L); //usando ticks, L pra dizer que e long
            TimeSpan t3 = new TimeSpan(2, 30, 45); // hora,minuto,segundo
            TimeSpan t4 = new TimeSpan(5, 7, 58, 7); //dias,horas,minutos,segundos
            TimeSpan t5 = new TimeSpan(5, 7, 58, 7, 356); //dias,horas,minutos,segundos e milisegundos

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            
        }
    }
}