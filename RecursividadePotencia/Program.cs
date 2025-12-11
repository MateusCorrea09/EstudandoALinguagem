using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RecursividadePotencia
{
    internal class Program
    {

        //Retorna A elevado a B, quando B = 0  retorna 1 
        //A = base b = expoente
        public static int Potencia(int a, int b)
        {
            if (b == 1)
            {
                //Quando o número é elavado a 0 o resultado é sempre 1
                return 1;
            }
            else //Enquanto b for maior que 0 e 1 ...
            {
                return a * Potencia(a, b - 1);// quebra em partes o problema e depois retorna cada resultado
            }                   //Dessa forma n precisa usar uma biblioteca para resolver esse problema
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Potencia(a,b));
            
        }
        
    }
}
