using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoGETeSET
{
    internal class Program
    {
        public class Carteira
        {
            public int dinheiro = 50;
            private int reserva = 30;

            //
            public int Dinheiro { get; set; }

            public void Acrescentar(int valor)
            {
                dinheiro += valor;
            }
            public void Retirar(int valor)
            {
                dinheiro -= valor;
            }
            public int MostrarDinheiro()
            {
                return dinheiro;
            }
            public int MostrarReserva()
            {
                return reserva;
            }
            public void alterarDinheiro(int nummero)
            {
                dinheiro = nummero;
            }
            public void alterarReserva(int nummero)
            {
                reserva = nummero;
            }
        }
        static void Main(string[] args)
        {
            Carteira cart = new Carteira();
            //Como nossa declararção do atributo esta publica isso significa
            //que qualquer um pode acessar esse atributo e moficicalo da forma que
            //quiser... pois ele esta como publico 'public int dinheiro = 50;'
            Console.WriteLine(cart.dinheiro); // O print mostrará 50
            //Acessando o atributo e redefinindo o valor para 10
            cart.dinheiro = 10;
            Console.WriteLine(cart.dinheiro);//O print mostrará 10 a partir de agora
            // ter um atributo que tenha um acesso como esse pode ser prejudicial


            //Em um atributo criado como 'private' só podem ser acessados pela própria
            //classe, isso significa que esses atributos só podem ser modificados a partir
            //dos métodos da classe 
            Console.WriteLine("O saldo é: "  + cart.MostrarDinheiro());
            Console.WriteLine("O saldo da reserva é [{0}]",cart.MostrarReserva());
            cart.alterarReserva(40); 
            Console.WriteLine("A reserva atualizada é: [{0}]",cart.MostrarReserva());

            // Existem formas mais eficientes de fazer coisas assim usando o Get e o Set
            //desse forma vc consegue acessar os atributos mesmo eles sendo privados
            cart.Dinheiro = 50; //Atraves dessa forma vc lê e escreve os atributos
            Console.WriteLine("O saldo em dinheiro é: [{0}]",cart.Dinheiro);
            //Se você desejar que seu atributo só seja de leitura vc pode colocar como 'private' o set
            //Dinheiro{get; private set;}
            //ou o inverso, se deseja que seu atributo só seja mostrado não alterado coloque como 'private' o get
            //Dinheiro {private get; set;}
        }
    }
}
