using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1036
{
    internal class Program
    {
        //Resolvendo a formula de baskara
        //No caso eu n preciso importar a biblioteca using System.Math; porque já é nativa aki
        static void Main(string[] args)
        {
                    //Aparentemente o Sistema possui um pequeno bug em relação a leitura de linhas
                    //e é preciso organiza-las em um vetor para ler
                 string[] valores = Console.ReadLine().Split(' ');
                 
                 double a = double.Parse(valores[0]);
                 double b = double.Parse(valores[1]);
                 double c = double.Parse(valores[2]);

            if (a == 0)
             {
                Console.WriteLine("Impossivel calcular");
             }
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;

                if (a == 0 || delta < 0)
                {
                    Console.WriteLine("Impossivel calcular");
                }
                else
                {
                    double resultadoA = (-b + Math.Sqrt(delta)) / (2 * a);
                    double resultadoB = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine($"R1 = {resultadoA:F5}");
                    Console.WriteLine($"R2 = {resultadoB:F5}");
                }

            }
            



        }
    }
}
