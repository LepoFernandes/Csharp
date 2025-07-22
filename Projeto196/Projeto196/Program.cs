using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args) 
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "997047225";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }


            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("All cookies: ");

            foreach(KeyValuePair<string, string> item in cookies) // PODE USAR O VAR NO LUGAR DE KEYVALUEPAIR
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}