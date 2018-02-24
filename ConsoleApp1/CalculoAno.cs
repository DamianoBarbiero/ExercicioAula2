using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class CalculoAno
    {
        public int ano { get; set; }
        public int mes { get; set; }
        public int dia { get; set; }
        public int idade { get; set; }
        public int anoatual { get; set; }

        public float CalcIdade(int dia, int mes, int ano, int anoatual)
        {
            return idade = (anoatual - ano) * 365 - (mes * 30) + dia;
        }
    }
}
