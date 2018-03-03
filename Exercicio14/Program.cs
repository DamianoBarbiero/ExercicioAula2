using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 15; i <=100 ; i++)
            {
                soma += i;
            }
            soma = (soma / 85);

            Console.WriteLine("A media: " + soma);
            Console.ReadLine();
        }
    }
}
