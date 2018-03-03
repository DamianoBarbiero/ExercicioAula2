using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            Console.WriteLine("Informe seu nome : ");
            p.nome = Console.ReadLine();
            do
            {
                Console.WriteLine("Informe seu sexo");
                p.sexo =  Console.ReadLine().ToUpper();
            } while (p.sexo == "f" && p.sexo != "m");

            Console.WriteLine("Informe sua altura : ");
            p.altura = Convert.ToDouble(Console.ReadLine());

            if (p.sexo == "F")
                Console.WriteLine(p.nome + " seu peso ideal é : " + p.CalculoPesoFem(p.altura));
            else
                Console.WriteLine(p.nome + " seu peso ideal é :" + p.CalculoPesoMasc(p.altura));

            Console.ReadLine();
        }
    }
}
