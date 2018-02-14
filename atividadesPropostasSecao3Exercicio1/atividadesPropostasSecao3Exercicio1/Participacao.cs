using System;
using System.Globalization;

namespace atividadesPropostasSecao3Exercicio1 {
    class Participacao {
        public double desconto { get; set; }
        public Artista artista { get; set; }
        public Filme filme { get; set; }

        public Participacao(double desconto, Artista artista, Filme filme) {
            this.desconto = desconto;
            this.artista = artista;
            this.filme = filme;
        }

        public double custo() { // não é static !!!
            return artista.cache - desconto ;
        }

        public override string ToString() {
            return "Artista: "
                + artista.nome
                + ", Cachê: "
                + artista.cache.ToString("F2", CultureInfo.InvariantCulture)
                + ", Desconto: "
                + desconto.ToString("F2", CultureInfo.InvariantCulture)
                +", Custo: "
                + custo().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
