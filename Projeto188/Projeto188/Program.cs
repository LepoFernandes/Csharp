using System;
using System.Collections.Generic;
using System.Globalization;
using Projeto188.Entities;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\in3.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List < Product > list = new List<Product>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Product(sr.ReadLine()));
                    }

                    list.Sort();
                    foreach (Product p in list) 
                    {
                        Console.WriteLine(p);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}