using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico10
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados p = new Dados();
            List<Dados> lst = new List<Dados>();
            decimal somaSalario = 0;
            int somaFilhos =0;
            decimal maior = 0;

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Informe o salario do " + (i+1) + "habitante");
                p.salario = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Informe o numero de filhos do habitante  " + (i+1));
                p.numfilhos = Convert.ToInt32(Console.ReadLine());
                somaSalario += p.salario;
                somaFilhos += p.numfilhos;
                maior = p.salario > maior ?  p.salario :  maior;
                lst.Add(p);
            }
            somaSalario = somaSalario / 4 ;
            somaFilhos = somaFilhos / 4;
          
            Console.WriteLine("A media dos Salarios da população " + somaSalario);
            Console.WriteLine("A media dos numeros de filhos da papulação é " + somaFilhos);
            Console.WriteLine("Maior sálario dos habitantes é de " + maior);
            Console.ReadLine();


        }
    }
}
