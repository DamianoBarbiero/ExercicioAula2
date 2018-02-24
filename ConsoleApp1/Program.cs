using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoAno calc = new CalculoAno();

            Console.WriteLine("Digite o dia que nasceu: ");
            calc.dia = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Digite o mes que nasceu: ");
            calc.mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o ano que nasceu: ");
            calc.ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o ano atual que nasceu: ");
            calc.anoatual = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Convertendo para dias: " +calc.CalcIdade(calc.dia, calc.mes, calc.ano, calc.anoatual));
            Console.ReadLine();
        }
    }
}
