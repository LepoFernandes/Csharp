using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int reposta = 0;
            int vitoriaInter = 0;
            int vitoriaGremio = 0;
            int empate = 0;
            int totalGrenais = 0;
            

            while (reposta != 2)
            {

                string[] gols = Console.ReadLine().Split(' ');

                int golInter = int.Parse(gols[0]);
                int golGremio = int.Parse(gols[1]);

                Console.WriteLine("Novo grenal (1-sim 2-nao)");

                reposta = int.Parse(Console.ReadLine());

                if (golInter > golGremio)
                {
                    vitoriaInter++;
                    totalGrenais++;
                }
                else if (golInter < golGremio)
                {
                    vitoriaGremio++;
                    totalGrenais++;
                }
                else if (golGremio == golInter)
                {
                    empate++;
                    totalGrenais++;
                }

            }

            

            if(vitoriaGremio > vitoriaInter)
            {
                Console.WriteLine(totalGrenais + " grenais");
                Console.WriteLine("Inter:" + vitoriaInter);
                Console.WriteLine("Gremio:" + vitoriaGremio);
                Console.WriteLine("Empates:" + empate);
                Console.WriteLine("Gremio venceu mais");

            }
            else if (vitoriaInter > vitoriaGremio)
            {
                Console.WriteLine(totalGrenais + " grenais");
                Console.WriteLine("Inter:" + vitoriaInter);
                Console.WriteLine("Gremio:" + vitoriaGremio);
                Console.WriteLine("Empates:" + empate);
                Console.WriteLine("Inter venceu mais");

            }
            else if (vitoriaGremio == vitoriaInter)
            {
                Console.WriteLine(totalGrenais + " grenais");
                Console.WriteLine("Inter:" + vitoriaInter);
                Console.WriteLine("Gremio:" + vitoriaGremio);
                Console.WriteLine("Empates:" + empate);
                Console.WriteLine("Nao houve vencedor");
            }

            

            
        }
    }
}