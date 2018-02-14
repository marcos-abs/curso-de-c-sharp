using System;
using System.Globalization;
using curso.dominio;

namespace aulaSecao3Aula7 {
    class Produto: IComparable {
        public int codigo { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }

        public Produto(int codigo, string nome, double preco) {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
        }

        public override string ToString() {
            return "Código: " 
                + codigo
                + ", Descrição: "
                + nome
                + ", Preço $ "
                + preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            Produto outro = (Produto) obj;
            int resultado = nome.CompareTo(outro.nome);
            if(resultado != 0) {
                return resultado;
            } else {
                return -preco.CompareTo(outro.preco);
            }
        }
    }
}
