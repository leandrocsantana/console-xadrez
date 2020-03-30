using System;
using tabuleiro;
using xadrez;    

namespace console_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('b', 4);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            //try
            //{

            //    Tabuleiro tab = new Tabuleiro(8, 8);

            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
            //    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));

            //    Tela.imprimirTabuleiro(tab);
            //}
            //catch (TabuleiroException e) {
            //    Console.WriteLine(e.Message);
            //}
                Console.ReadLine();

        }
    }
}
