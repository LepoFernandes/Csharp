using Projeto162.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto162.Entities
{
    class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public StatusCliente StatusCliente { get; set; }


        public Cliente()
        {
        }


        public Cliente(int iD, string nome, string email, StatusCliente statusCliente)
        {
            ID = iD;
            Nome = nome;
            Email = email;
            StatusCliente = StatusCliente.Ativo;
        }
    }
}
