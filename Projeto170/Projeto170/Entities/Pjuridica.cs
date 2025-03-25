using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto170.Entities
{
    internal class Pjuridica : Contribuinte
    {
        public int Nfuncionarios { get; set; }

        public Pjuridica() { }

        public Pjuridica(int nfuncionarios, string nome, double rendaAnual) 
          :base(nome, rendaAnual)
        {
            Nfuncionarios = nfuncionarios;
        }

        public override double CalculoImposto()
        {
            double imposto = 0;

            if (Nfuncionarios > 10) 
            {
                imposto = RendaAnual * 0.14;
            }else
            {
                imposto = RendaAnual * 0.16;
            }

            return imposto;
        }
    }
}
