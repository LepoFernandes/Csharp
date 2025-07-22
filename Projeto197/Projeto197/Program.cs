using System;
using System.IO;

using System.Collections.Generic;

namespace curso
{
    class Program
    {
        static void Main(string[] args) 
        {
            Dictionary<string, int> dados1 = new Dictionary<string, int>();

            Console.WriteLine("Enter file full path: ");

            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        

                        if (dados1.ContainsKey(name))
                        {
                            dados1[name] += votes;
                        }
                        else
                        {
                            dados1[name] = votes;
                        }
                        
                    }
                }
            }
            catch (IOException e) 
            {
                Console.WriteLine(e.Message);   
            }

            Console.WriteLine("Final Count: ");

            foreach(KeyValuePair<string, int> dados in dados1)
            {
                Console.WriteLine(dados.Key + ": " + dados.Value);
            }
        }
    }
}