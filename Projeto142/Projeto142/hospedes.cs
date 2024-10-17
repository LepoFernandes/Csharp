using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto142
{
    internal class hospedes
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string NomeQuarto { get; set; }

        public hospedes() { }
        public hospedes(string name, string email)
        {
            Name = name;
            Email = email;
        }

        
    }
}
