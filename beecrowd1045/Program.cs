using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double a = double.Parse(entrada[0]);
            double b = double.Parse(entrada[1]);
            double c = double.Parse(entrada[2]);
            if (a == 0 || b == 0 || c == 0) { }
            else if (a == b && b == a && a == c) { Console.WriteLine("TRIANGULO EQUILATERO"); }
            else if (a == b || a == c || c == b) { Console.WriteLine("TRIANGULO ISOSCELES"); }
            else if (a >= b + c) { Console.WriteLine("NAO FORMA TRIANGULO"); }
            else if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)) { Console.WriteLine("TRIANGULO RETANGULO"); }
            else if (Math.Pow(a, 2) >= Math.Pow(b, 2) + Math.Pow(c, 2)) { Console.WriteLine("TRIANGULO OBTUSANGULO"); }
            else if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2)) { Console.WriteLine("TRIANGULO ACUTANGULO"); }
        }
    }
}
