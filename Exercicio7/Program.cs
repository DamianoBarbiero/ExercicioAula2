using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Valores val = new Valores();
            int maior = 0;

            Console.WriteLine("Informe os Valores Inteiros");

            Console.WriteLine("Primeiro Valor : ");
            val.val1 = Convert.ToInt32(Console.ReadLine());
            maior = val.val1;
            do
            {
                Console.WriteLine("Segundo Valor : ");
                val.val2 = Convert.ToInt32(Console.ReadLine());

            } while (val.val2 == val.val1);
            maior = val.val2 > maior ? val.val2 : maior;
            do
            {
                Console.WriteLine("Terceiro Valor : ");
                val.val3 = Convert.ToInt32(Console.ReadLine());
            } while (val.val3 == val.val1 || val.val3 == val.val2);
            maior = val.val3 > maior ? val.val3 : maior;

            Console.WriteLine("O maior Valor Informado foi : " + maior);
            Console.ReadLine();

        }
    }
}
