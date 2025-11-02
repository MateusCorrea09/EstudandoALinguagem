using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1133
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
           
                // eu preciso criar um contador que começa em um ponto e vai até ele
                int inicial = 0;
                int final = 0;
                if (x > y) { inicial = y; final = x; } else { inicial = x; final = y; }
                //Console.WriteLine("inicio = {0} // final {1}",inicial,final);
                // n da pra usar o % para achar o resto do valor... quando se refere a um valor restante em ponto e virgula
            //tava falktando o +1! porque ele deve começar a contar depois do valor inicial!   
            for (int i = inicial + 1; i < final; i++)
                {
                    if (i % 5 == 2 || i % 5 == 3)
                    {
                        Console.WriteLine(i);
                    }
                }
            
           
            

    
        }
    }
}
