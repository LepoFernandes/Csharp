﻿using System;
using System.IO;
using Projeto195.Entities;

namespace curso
{
    class Program
    {
        static void Main(string[] args) 
        {

            HashSet<LogRecord> records = new HashSet<LogRecord>();

            Console.WriteLine("Enter file full path: ");

            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        records.Add(new LogRecord { Username = name, Instant = instant });                    
                    }

                    Console.WriteLine("Total users: " + records.Count);
                }
            }
            catch (IOException e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}