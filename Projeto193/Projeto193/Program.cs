using System;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedSet<int> A = new SortedSet<int>();
            SortedSet<int> B = new SortedSet<int>();
            SortedSet<int> C = new SortedSet<int>();

            Console.WriteLine("How many students for course A? ");

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) 
            {
                int a = int.Parse(Console.ReadLine());                
                A.Add(a);
            }

            Console.WriteLine("How many students for course B? ");

            int N2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < N2; i++)
            {
                int b = int.Parse(Console.ReadLine());                
                B.Add(b);
            }

            Console.WriteLine("How many students for course C? ");

            int N3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < N3; i++)
            {
                int c = int.Parse(Console.ReadLine());              
                C.Add(c);
            }



            SortedSet<int> todos = new SortedSet<int>();

            static void PrinterCollection<T>(IEnumerable<T> collection)
            {
                foreach (T item in collection)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine();
            }

            todos.UnionWith(A);
            todos.UnionWith(B);
            todos.UnionWith(C);

            PrinterCollection(todos);
            Console.WriteLine("Total students: " + todos.Count);

        }
    }
}