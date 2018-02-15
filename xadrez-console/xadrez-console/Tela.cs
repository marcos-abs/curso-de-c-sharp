using System;
using tabuleiro;

namespace xadrez_console {
    class Tela {
        public static void imprimirTabuleiro(Tabuleiro tab) {
            for(int x = 0; x < tab.linhas; x++) {
                for (int y = 0; y < tab.colunas; y++) {
                    if (tab.peca(x, y) == null) {
                        Console.Write("- ");
                    } else {
                        Console.Write(tab.peca(x, y) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
