using System;
using tabuleiro;

namespace xadrez_console {
    class Tela {
        public static void imprimirTabuleiro(Tabuleiro tab) {
            for(int x = 0; x < tab.linhas; x++) {
                Console.Write(8 - x + " ");
                for (int y = 0; y < tab.colunas; y++) {
                    if (tab.peca(x, y) == null) {
                        Console.Write("- ");
                    } else {
                        //Console.Write(tab.peca(x, y) + " ");
                        imprimirPeca(tab.peca(x, y));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca) {
            if (peca.cor == Cor.Branca) {
                Console.Write(peca);
            } else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
