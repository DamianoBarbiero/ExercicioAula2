using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            numeros = new int[10];
            int soma = 0;

            for (int i = 0; i < 10; i++) {
                
                Console.WriteLine("Insira o valor [" + i + "] :" );
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                soma += numeros[i];
            }

            Console.WriteLine("O valor da soma: " + soma);
            Console.ReadLine();
        }
    }
}
