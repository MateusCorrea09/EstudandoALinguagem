using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PELO QUE EU ENTENDI VC TEM USAR O CONCEITO DE DIVISÃO E COMPARAR SE O 
            //RESTO DA DIVISÃO É RESULTAANTE EM 0 OU 1 ...
            // PEGA X E DIVIDE POR Y AI VC VE SE RESULTA 0 SE SIM É MULTIPLO
            string[] entrada = Console.ReadLine().Split(' ');
            
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);

            if (x % y == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else if (y % x == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else if (x % y != 0)
            {
                Console.WriteLine("Nao sao Multiplos");
            }
            else if (y % x != 0)
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
