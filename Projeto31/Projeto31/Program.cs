using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int Idade, Ianos, Imeses, Idias, ano , mes;
            ano = 365;
            mes = 30;
            Idade = int.Parse(Console.ReadLine());

            Ianos = Idade / ano;
            int RestoIanos = Idade % ano;

            Imeses = RestoIanos / mes;
            Idias = RestoIanos % mes;
             
            Console.WriteLine(Ianos + " ano(s)");
            Console.WriteLine(Imeses + " mes(es)");
            Console.WriteLine(Idias + " dia(s)");

        }
    }
}
