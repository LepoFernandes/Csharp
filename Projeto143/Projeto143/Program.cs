using System;
using System.Collections.Generic;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");

            foreach (string item in list) 
            {
                Console.WriteLine(item);
            }
        }
    }
}