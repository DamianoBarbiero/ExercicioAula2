using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class CalculosTemp
    {
        public int menortemp { get; set; }
        public int maiortemp { get; set; }
        public int tempmedia { get; set; }

        public int CaclMenor(int[] temperatura)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++) {
                    if (temperatura[i] <= temperatura[i]) {
                        menortemp = temperatura[i];
                    } 
                }
            }
            return menortemp;
        }
        public int CaclMaior(int[] temperatura)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    if (temperatura[i] >= temperatura[j])
                    {
                        maiortemp = temperatura[i];
                    }
                }
            }
            return maiortemp;
        }

        public int CaclMedia(int[] temperatura)
        {
            for (int i = 0; i < 5; i++)
            {
                tempmedia += temperatura[i];
            }
            tempmedia = (tempmedia / 5);
            return tempmedia;
        }

    }
}
