using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Inf um numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

            } while (numero == 0);

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine("----------------- : " +i );
            }
            Console.ReadLine();
        }
    }
}
