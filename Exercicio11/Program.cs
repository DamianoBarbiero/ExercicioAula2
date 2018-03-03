using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperatura;
            temperatura = new int[5];
            CalculosTemp calc = new CalculosTemp();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira a [" + (i+1) + "ª] temperatura :");
                temperatura[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("menor temp:" + calc.CaclMenor(temperatura));
            Console.WriteLine("maior temp:" + calc.CaclMaior(temperatura));
            Console.WriteLine("media das temps:" + calc.CaclMedia(temperatura));
            Console.ReadLine();

        }
    }
}
