using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vetor para armazenar as entradas seguidas :D
            
            string[] entradas = Console.ReadLine().Split(' '); 
            double x = double.Parse(entradas[0]); // pega a entrada localizada na posição 0 e armazena dentro de X
            double y = double.Parse(entradas[1]); // pega a entrada localizada na posição 0 e armazena dentro de y

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            }
            //falto essa aprte :D
            else if (x == 0) { Console.WriteLine("Eixo Y"); }
            else if (y == 0) { Console.WriteLine("Eixo X"); }

        }
    }
}
