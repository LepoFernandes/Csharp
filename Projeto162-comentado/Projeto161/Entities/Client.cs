using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace Projeto161.Entities 
{
    class Client // Define a classe Client, que representa um cliente no sistema.
    {
        public string NameClient { get; set; } // Propriedade que armazena o nome do cliente. O modificador 'get; set;' permite leitura e escrita.
        public string email { get; set; } // Propriedade que armazena o email do cliente.
        public DateTime birthDate { get; set; } // Propriedade que armazena a data de nascimento do cliente, do tipo DateTime.

        // Construtor padrão, sem parâmetros, que permite criar um objeto Client sem passar dados de entrada.
        public Client() { }

        // Construtor com parâmetros, permitindo criar um objeto Client já com os dados fornecidos.
        public Client(string nameClient, string email, DateTime birthDate)
        {
            NameClient = nameClient; // Atribui o valor do nome do cliente à propriedade 'NameClient'.
            this.email = email; // Atribui o valor do email à propriedade 'email'.
            this.birthDate = birthDate; // Atribui a data de nascimento à propriedade 'birthDate'.
        }
    }
}
