using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RecursividadeNumeroTriangulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(triangular(4));
            //tabuada(4, 10);
            Console.WriteLine(tabuadasimples(4, 10));
            //Console.WriteLine(fatorialN(4));
            //Fatorial2(5);

        }
        public static int triangular(int i)
        {
            if (i == 1) { return 1; }// caso base! evita que o programa entre num loop infinito
            else { return i + triangular(i - 1); } // a divisão em pequenos blocos menores do problema
        }
        public static int tabuada(int numeroEntrada, int Multiplicador)// essa exibe o passo a passo do resultado 
        {
            if (Multiplicador == 1) { // mas nessa parte ele exibe só no final o numero entrada * 1!
                int resultado = numeroEntrada * 1; // não entendi como resolver essa questão de organização
                Console.WriteLine("{0} * "+ "1 "+"  = " + resultado, numeroEntrada);
                return resultado;
            }
            else {
                int resultado = numeroEntrada * Multiplicador;
                Console.WriteLine("{0} * " + Multiplicador + " = " + resultado, numeroEntrada);
                tabuada(numeroEntrada, Multiplicador - 1);
                return resultado;
            }
        }
        public static int tabuadasimples(int numeroEntrada, int Multiplicador)
        {
            if (Multiplicador == 1)
            {
                int resultado = numeroEntrada * 1;
                return resultado;
            }
            else
            {
                int resultado = numeroEntrada * Multiplicador;
                tabuadasimples(numeroEntrada, Multiplicador - 1);
                return resultado;
            }
        }



        public static int fatorialN(int n)
        {
            if (n == 1) { return 1; }
            else { return n * fatorialN(n - 1); }// a diferença é que nesse exemplo o N é multiplciado pelo resultado da
                                                  // da função que criamos com n - 1!
        }
        public static int Fatorial2(int n) // esse imprime na tela os prints
        {
            if (n == 1) { Console.WriteLine(1); return 1; } else
            {
                int resultado = n * fatorialN(n - 1);// armazena o inteiro dentro de uma variavel, então não da erro
                Console.WriteLine(resultado); //quando printamos na tela, o print pode dar priplema com o return
                return resultado; //porque o return espera um inteiro e o print é outra coisa... não um inteiro
            }
        }
    }
}
