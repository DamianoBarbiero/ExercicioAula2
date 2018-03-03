using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
             string result = "";
             string cod = "";
            string prod = "";

            List<Produto> lista = new List<Produto>();
            Console.WriteLine("Informe os produtos e precos");

            //for (int i=0; i<=15; i++){
                Console.WriteLine("Produto" + 1);
                result = Console.ReadLine();
                cod = result.Remove(result.IndexOf(" "));
            
            //prod = result.Remove (result.IndexOf(" "),result.Length-1 );
                //result.Remove(result.IndexOf(result , cod.Length, result.Length));
            //  Console.WriteLine(cod);
                Console.Read();

                
                    

            }
            

        }
    }

