using System;
using System.Collections.Generic;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a lista
            List<string> list = new List<string>();

            //Usando o comando add
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Maria");
            list.Add("Anna");

            //Usando o comando insert
            list.Insert(2, "Marco");

            foreach (string item in list) 
            {
                Console.WriteLine(item);
            }

            //Tamanho da lista
            Console.WriteLine("Tamanho da lista: " + list.Count);

            //Usando find com expressoes lambdas
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A' = " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A' = " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First 'A' = " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last 'A' = " + pos2);

            //Filtrando a lista(usa uma segunda lista)

            List<string> list2 = list.FindAll(x=> x.Length == 5);
            Console.WriteLine("------------------");

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            //Remover elementos da lista

            list.Remove("Alex");

            Console.WriteLine("------------------");

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("------------------");

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(0);
            Console.WriteLine("------------------");

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            list.RemoveRange(0, 1);
        }
    }
}