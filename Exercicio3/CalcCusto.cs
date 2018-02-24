using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class CalcCusto
    {
        public decimal custofabrica { get; set; }

        public decimal CalcCarrot(decimal custofabrica)
        {

            return custofabrica + (custofabrica * 0.28m) + (custofabrica * 0.45m);
        }
    }
}
