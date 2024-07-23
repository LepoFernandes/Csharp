using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            // INICIANDO O NUMERO DE ENTRADAS
            int N = int.Parse(Console.ReadLine());

            // INSTANCIANDO OS VETORES
            string[] names = new string[N];
            int[] age = new int[N];
            
            //INICIANDO AS VARIAVEIS PRA SABER O MAIOR NUMERO
            int maior = age[0];
            int indiceMaior = 0;

            //LOOP PRAS ENTRADAS E PRA COLOCAR OS VALORES NOS VETORES ORIGINAIS
            for (int i = 0; i < N; i++) 
            {
                string[] pessoas = Console.ReadLine().Split(' ');

                names[i] = pessoas[0];
                age[i] = int.Parse(pessoas[1]);
            }
            //LOOP PARA SABER O MAIOR NUMERO E LIGAR COM O NOME USANDO O INDICEMAIOR
            for (int i = 0;i < age.Length; i++)
            {
                if (age[i] > maior)
                {
                    maior = age[i];
                    indiceMaior = i;
                }
            }


            Console.WriteLine("A pessoa mais velha : " + names[indiceMaior]);





            

            


        }
    }
}