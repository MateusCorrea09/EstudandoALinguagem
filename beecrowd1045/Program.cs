using System;

class Program
{
    static void Main()
    {
        string[] entrada = Console.ReadLine().Split(' ');
        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);
        double c = double.Parse(entrada[2]);

        double[] lados = { a, b, c };
        Array.Sort(lados);
        Array.Reverse(lados);

        a = lados[0];
        b = lados[1];
        c = lados[2];
        if (a >= b + c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            //Tem essa questão com testagens de if, verificação de mais de um 
            //if no código, n entendi isso muito bem vou pegar pra ver isso com mais
            //calma depois
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else
                Console.WriteLine("TRIANGULO ACUTANGULO");

            if (a == b && b == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            else if (a == b || a == c || b == c)
                Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}
