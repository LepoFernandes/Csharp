using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto129
{
    internal class aluno
    {
        public string nomeAluno;
        public double nota1;
        public double nota2;
        public double nota3;
        

        public double notaTotal()
        {
            return nota1 + nota2 + nota3;
        }

        public double RestanteNota()
        {
            return 60.0 - notaTotal();
        }
    }
}
