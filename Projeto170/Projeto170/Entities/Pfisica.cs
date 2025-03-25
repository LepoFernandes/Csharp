using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto170.Entities
{
    internal class Pfisica : Contribuinte
    {
        public double GastosSaude {  get; set; }


        public Pfisica() { }

        public Pfisica(double gastosSaude,string nome, double rendaAnual) 
        : base(nome, rendaAnual) 
        {
            GastosSaude = gastosSaude;
        }

        public override double CalculoImposto()
        {
            double imposto = 0;

            if (RendaAnual < 20000.00)
            {
                 imposto = RendaAnual * 0.15;

            }else if (RendaAnual >= 20000.00)
            {
                imposto = RendaAnual * 0.25;

            } 

            if (GastosSaude > 0)
            {
                imposto = imposto - (GastosSaude * 0.5);
            }

            return imposto;
        }
    }
}
