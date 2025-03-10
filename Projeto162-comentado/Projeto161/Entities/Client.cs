using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto161.Entities
{
    class Client
    {
        public string NameClient { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }

        public Client() { }
        public Client(string nameClient, string email, DateTime birthDate)
        {
            NameClient = nameClient;
            this.email = email;
            this.birthDate = birthDate;
        }
    }
}
