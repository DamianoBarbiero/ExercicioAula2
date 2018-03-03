
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Triangulo
    {
        public int lado1 { get; set; }
        public int lado2 { get; set; }
        public int lado3 { get; set; }

        public bool CalculoTraingulo(int l1, int l2, int l3) {
            if (((l1 + l2) > l3) && ((l1 + l3) > l2) && ((l2 + l3) > l1))
                return true;
           
            else 
               return false;
        }

    }
}
