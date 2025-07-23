using System;
using Projeto198.Extensions;


namespace Curso
{
    class Program
    {
        static void Main(string[] args) 
        {
            DateTime dt = new DateTime(2025, 07, 23, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students.";
            Console.WriteLine(s1.Cut(15));
        }
    }
}