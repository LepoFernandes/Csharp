﻿using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines) 
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }               
            } 
            catch(IOException e)
            {
                Console.Write("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}