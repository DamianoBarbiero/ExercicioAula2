using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Percentual perc = new Percentual();

            Console.WriteLine("Digite o total de eleitores: ");
            perc.totaleleitores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite os votos em brancos: ");
            perc.vb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite os votos nulos : ");
            perc.nl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite os votos validos: ");
            perc.vl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Percentual de votos brancos: " +perc.CalcPercentual(perc.totaleleitores, perc.vb));
            Console.WriteLine("Percentual de votos nulos: " + perc.CalcPercentual(perc.totaleleitores, perc.nl));
            Console.WriteLine("Percentual de votos validos: " + perc.CalcPercentual(perc.totaleleitores, perc.vl));
            Console.ReadLine();
        }
    }
}
