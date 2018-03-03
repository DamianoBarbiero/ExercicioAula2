using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri = new Triangulo();
            bool result = false;
            Console.WriteLine("Informe os Lados do Triangulo");

            Console.WriteLine("Primeiro lado : ");

            tri.lado1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo lado : ");
            tri.lado2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Terceiro lado : ");
            tri.lado3 = Convert.ToInt32(Console.ReadLine());
            result = tri.CalculoTraingulo(tri.lado1, tri.lado2, tri.lado3);
            if(result)
              Console.WriteLine("Os Lados Formam um Triangulo");
            else
              Console.WriteLine("Os Lados NÃO Formam um Triangulo");
            Console.ReadLine();


        }
    }
}
