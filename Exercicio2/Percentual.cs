using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Percentual
    {
        public int totaleleitores { get; set; }
        public int vb { get; set; }
        public int nl { get; set; }
        public int vl { get; set; }

        public float CalcPercentual(int totaleleitores, int votos)
        {
            int retperc = 0;

            retperc = (votos * 100) / totaleleitores;
                return retperc;
        }
    }
}
