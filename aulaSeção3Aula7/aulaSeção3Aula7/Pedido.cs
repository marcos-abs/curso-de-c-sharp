using System;
using System.Collections.Generic;
using System.Globalization;
using curso.dominio;

namespace aulaSecao3Aula7 {
    class Pedido {

        public int codigo { get; set; }
        public DateTime data { get; set; }

        public List<ItemPedido> itens { get; set; }

        public Pedido (int codigo, int dia, int mes, int ano) {
            this.codigo = codigo;
            data = new DateTime(ano, mes, dia);
            itens = new List<ItemPedido>();
        }

        public double valorTotal() {
            double soma = 0.0;
            for (int x=0; x<itens.Count; x++) {
                soma = soma + itens[x].subTotal();
            }
            return soma;
        }

        public override string ToString() {
            string s = "Pedido: "
                + codigo
                + ", Data: " + data.Day + "/" + data.Month + "/" + data.Year + '\n'
                + "Itens do pedido:" + '\n';
            for (int x=0; x<itens.Count; x++) {
                s = s + itens[x] + '\n';
            }
            s = s + "Total do pedido: " + valorTotal().ToString("F2", CultureInfo.InvariantCulture);
            return s;
        }
    }
}
