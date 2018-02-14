using System;
using System.Globalization;

namespace atividadesPropostasSecao3Exercicio1 {
    class Artista : IComparable {
        public int codigo { get; set; }
        public string nome { get; set; }
        public double cache { get; set; }

        public Artista(int codigo, string nome, double cache) {
            this.codigo = codigo;
            this.nome = nome;
            this.cache = cache;
        }

        public override string ToString() {
            return "Código: "
                + codigo
                + ", Nome: "
                + nome
                + ", Valor do cachê: "
                + cache.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            Artista outro = (Artista) obj;
            int resultado = nome.CompareTo(outro.nome);
            return resultado;
        }
    }
}
