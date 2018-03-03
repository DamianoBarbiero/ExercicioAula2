using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico5
{
    class Pessoa
    {
        public string nome { get; set; }

        public double altura { get; set; }

       public  string sexo { get; set; }

        public double CalculoPesoMasc(double alt) {
            double pesoIdeal=0;
            pesoIdeal = (72.7 * alt) - 58;
            return pesoIdeal;
        }

        public double CalculoPesoFem(double alt)
        {
            double pesoIdeal = 0;
            pesoIdeal = (62.1 * alt) - 44.7;
            return pesoIdeal;
        }


    }
}
