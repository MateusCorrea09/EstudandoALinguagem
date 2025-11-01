using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoALinguagem.GETeSET
{
     class Carteira
    {
        public int dinheiro = 50;

        public void Acrescentar(int valor)
        {
            dinheiro += valor;
        }
        public void retirar(int valor)
        {
            dinheiro -= valor;
        }
    }
    public class Joao
    {
        static void Main(String[] args)
        {
            Carteira cart = new Carteira();
            Console.WriteLine(cart.dinheiro);
            
            //cart.dinheiro = 10;
        }
    }
}
