﻿using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args) 
        {

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Division by zero isn't allowed");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error!" +  e.Message);
            }
        }
    }
}