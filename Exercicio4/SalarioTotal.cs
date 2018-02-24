using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class SalarioTotal
    {
        public decimal salario { get; set; }
        public decimal numvendas { get; set; }
        public decimal valorvendastotal { get; set; }


        public decimal Calc(decimal salario, decimal numvendas, decimal valorvendastotal) {

            decimal vendastotais = 0;
            decimal comissao = 0;

            comissao = numvendas * 100; //comissão de 100 reais por venda.
            vendastotais =  valorvendastotal * 0.05m;

            return salario += comissao + vendastotais;

        }

    }
}
