using Projeto142;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            

            hospedes[] quartos = new hospedes[10];

            for (int i = 0; i < quartos.Length; i++)
            {
                quartos[i] = null;
            }

            Console.WriteLine("Quantos hospedes deseja alocar?");

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Agora vamos cadastrar o hospede.");

                Console.WriteLine("Escolha um quarto e complete o cadastro: ");



                Console.WriteLine("Qual numero do quarto?");

                int numQuarto = int.Parse(Console.ReadLine());

                if (quartos[numQuarto] == null)
                {
                    hospedes x = new hospedes();

                    Console.WriteLine("Quarto disponivel vamos seguir.");

                    Console.Write("Digite seu nome: ");
                    x.Name = Console.ReadLine();

                    Console.Write("Qual seu email: ");
                    x.Email = Console.ReadLine();

                    quartos[numQuarto] = new hospedes { Email = x.Email, Name = x.Name, NomeQuarto = "quarto " + numQuarto };

                    Console.WriteLine(x.Name + " cadastrado no quarto " + numQuarto + ".");
                }
                else
                {
                    Console.WriteLine("Quarto ocupado.");
                }

            }

            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < quartos.Length; i++)
            {

                if (quartos[i] != null)
                {
                    Console.WriteLine("Quarto " + i + ": " + quartos[i].Name + ", " + quartos[i].Email + ".");
                }
            }

        }
    }
}