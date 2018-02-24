using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcCusto calc = new CalcCusto();

            Console.WriteLine("Valor do custo de Fabrica: ");
            calc.custofabrica = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("O valor do carro é: " + calc.CalcCarrot(calc.custofabrica));
            Console.ReadLine();
        }
    }
}
