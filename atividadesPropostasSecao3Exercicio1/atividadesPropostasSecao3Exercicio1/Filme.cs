using System;
using System.Globalization;
using System.Collections.Generic;

namespace atividadesPropostasSecao3Exercicio1 {
    class Filme {
        public int codigo { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }

        public List<Participacao> partFilme { get; set; }

        public Filme(int codigo, string titulo, int ano) {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
            partFilme = new List<Participacao>();

        }

        public double custoTotal() { // não é static !!!
            double soma = 0.0;
            for (int i = 0; i < partFilme.Count; i++) {
                soma = soma + partFilme[i].custo();
            }
            return soma;
        }

        public override string ToString() {
            string s = "Código do filme: "
                + codigo
                + ", Título: "
                + titulo
                + ", Ano de lançamento: "
                + ano
                + "\n Participações:\n";

            for (int i = 0; i < partFilme.Count; i++) {
                s = s + partFilme[i] + "\n";
            }
            s = s + "Total do filme: " + custoTotal().ToString("F2", CultureInfo.InvariantCulture);

            return s;

        }

    }
}
