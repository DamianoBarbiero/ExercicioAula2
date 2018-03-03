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
            Idade idade = new Idade();
            Console.WriteLine("Informe o anos");
            idade.ano = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Informe os meses");
            idade.meses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe os dias ");
            idade.dias = Convert.ToInt32(Console.ReadLine());

            int resul = (idade.ano * 365) + (idade.meses * 30) + idade.dias;

            Console.WriteLine("Sua idade em dias é : " + resul);
            Console.ReadLine();
        }
    }
}
