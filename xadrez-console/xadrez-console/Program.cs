using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                
                while(!partida.terminada) {
                    try {
                        Console.Clear();
                        Tela.imprimirPartida(partida);

                        Console.Write("\nOrigem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.Write("\nDestino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    } catch (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Tela.imprimirPartida(partida);

            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            /*
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            */

            Console.Write("\nPressione ENTER para finalizar:");
            Console.ReadLine();
        }
    }
}
