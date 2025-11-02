using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //para resolver esse exercicio eu preciso entender oq faz um triangulo ser um triangulo
            // é baseado na soma de duas entradas especificas resultarem em um valor maior que a da 
            // terceira entrada e assim  por diante! vou tentar aplicar isso aki :D

            string[] entradas = Console.ReadLine().Split(' ');

            double a = double.Parse(entradas[0]);
            double b = double.Parse(entradas[1]);
            double c = double.Parse(entradas[2]);

            // sequência de checagens 
            if (a + b > c)
            {
                if (a + c > b)
                {
                    if (b + c > a)
                    {
                        double resultado = a + b + c;
                        Console.WriteLine($"Perimetro = {resultado:F1}");
                    }
                    else
                    {
                        double resultado = ((a + b) * c) / 2;
                        Console.WriteLine($"Area = {resultado:F1}");
                    }
                }
                else
                {
                    double resultado = ((a + b)* c) / 2;
                    Console.WriteLine($"Area = {resultado:F1}");
                }

            }
            else
            {
                double resultado = ((a + b) * c) / 2;
                Console.WriteLine($"Area = {resultado:F1}");
            }
        }
    }
}
