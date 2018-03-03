using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salario = 0;
            decimal valorVendas = 0;
            decimal resultado = 0;
            Console.WriteLine("Informe o salario fixo :");
            salario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor das vendas : ");
            valorVendas = Convert.ToInt32(Console.ReadLine());

            resultado = valorVendas * 0.03m;
            if (valorVendas > 1500)
            {
                salario +=  (valorVendas * 0.05m);
            }

            salario += resultado;
            Console.WriteLine("result" + salario);
            Console.ReadLine();

            

        }
    }
}
