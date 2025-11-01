using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double CachorroQuente = 4.0;
            double XSalada = 4.50;
            double XBacon = 5.00;
            double TorradaSimples = 2.00;
            double Refrigerante = 1.50;

            string[] valores = Console.ReadLine().Split(' ');
            int entrada = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);
            if (entrada == 1)
            {
                double resultado = CachorroQuente * quantidade;
                Console.WriteLine($"Total: R$ {resultado:F2}");
            }
            if (entrada == 2)
            {
                double resultado = XSalada * quantidade;
                Console.WriteLine($"Total: R$ {resultado:F2}");
            }
            if (entrada == 3)
            {
                double resultado = XBacon * quantidade;
                Console.WriteLine($"Total: R$ {resultado:F2}");
            }
            if (entrada == 4)
            {
                double resultado = TorradaSimples * quantidade;
                Console.WriteLine($"Total: R$ {resultado:F2}");
            }
            if (entrada == 5)
            {
                double resultado = Refrigerante * quantidade;
                Console.WriteLine($"Total: R$ {resultado:F2}");
            }

        }
    }
}
