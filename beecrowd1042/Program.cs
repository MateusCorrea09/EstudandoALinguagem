using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vetorTaman = 3;
            string[] entradas = Console.ReadLine().Split(' ');
            
            //Deixar as ordens definidas
            int[] entradaIniciais = new int[vetorTaman];
            entradaIniciais[0] = int.Parse(entradas[0]); // 2
            entradaIniciais[1] = int.Parse(entradas[1]); // 8
            entradaIniciais[2] = int.Parse(entradas[2]); // 1


            // Pelo que eu entendi, eu queria separar as coisas, mas a troca de posição
            //de valores dentro de um vetor deve aconteer dentro do vetor que esta sendo
            //manipulado no momento. Então atenção! se vc quer manipular um determinado vetor
            // vc tem que ter certeza de que o vetor que esta sendo manipulado esta sendo atualziado
            int[] OrdemCres = (int[])entradaIniciais.Clone();

            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (OrdemCres[i] > OrdemCres[j])
                    {
                        //nessa etapa eu cometi o erro de manipular o vetor OrdemCres, mas sempre usando
                        //o vetor EntradasIniciais como prâmentro de comparação, então sempre resultava
                        //em um vetor desorganizado. O vetor que esta sendo manipulado deve ser o memso
                        // que após cada manipulação esta sendo atualziado.
                        int aux = OrdemCres[i];
                        OrdemCres[i] = OrdemCres[j];
                        OrdemCres[j] = aux;
                    }
                }
            }

            //print
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(OrdemCres[i]);
            }
            //importante saber que se vc coloca quebra de linah dentro dessa parte
            //ele entende que vc quer pular duas linhas :D
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(entradaIniciais[i]);
            }

        }
    }
}
