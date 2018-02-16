﻿namespace tabuleiro {
    abstract class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

        public void incrementarQteMovimentos() {
            qteMovimentos++;
        }

        public void decrementarQteMovimentos() {
            qteMovimentos--;
        }

        public bool existeMovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();
            for (int x=0; x<tab.linhas; x++) {
                for (int y=0; y<tab.colunas; y++) {
                    if (mat[x, y]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos) {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
