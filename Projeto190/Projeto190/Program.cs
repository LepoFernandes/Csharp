using System;
using Projeto190.Entities;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Client A = new Client{Name = "Maria", Email = "maria@gmail.com"};

            Client B = new Client { Name = "Alex", Email = "alex@gmail.com" };

            
            Console.WriteLine(A.Equals(B));
            Console.WriteLine(A == B);
            Console.WriteLine(A.GetHashCode());
            Console.WriteLine(B.GetHashCode());
        }
    }
}