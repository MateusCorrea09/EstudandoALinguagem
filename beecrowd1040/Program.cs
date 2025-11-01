using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            double n1 = double.Parse(valores[0]); //peso 2
                n1 = n1 * 2;
            double n2 = double.Parse(valores[1]); //peso 3
                n2 = n2 * 3;
            double n3 = double.Parse(valores[2]); //peso 4
                n3 = n3 * 4;
            double n4 = double.Parse(valores[3]); //peso 1
                n4 = n4 * 1;

            double resultado = (n1 + n2 + n3 + n4) / 10;
            resultado = Math.Truncate(resultado * 10) / 10;

            if (resultado >= 5.0 && resultado <= 6.9)
            {
                Console.WriteLine($"Media: {resultado:F1}");
                Console.WriteLine("Aluno em exame.");
               
                double exame = double.Parse(Console.ReadLine());
                double novoResult = (resultado + exame) / 2;
                novoResult = Math.Truncate(novoResult * 10) / 10;

                Console.WriteLine($"Nota do exame: {exame:F1}");
                if (novoResult > 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {novoResult:F1}");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {novoResult:F1}");
                }
            }
            else if (resultado >= 7.0)
            {
                Console.WriteLine($"Media: {resultado:F1}");
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine($"Media: {resultado:F1}");
                Console.WriteLine("Aluno reprovado.");
            }
            
        }
    }
}
