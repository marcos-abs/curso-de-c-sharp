using System.Globalization;
using curso.dominio;

namespace aulaSecao3Aula7 {
    class ItemPedido {

        public int quantidade { get; set; }
        public double porcentagemDesconto { get; set; }

        public Produto produto { get; private set; }
        public Pedido pedido { get; private set; }

        public ItemPedido(int quantidade, double porcentagemDesconto, Pedido pedido, Produto produto) {
            this.quantidade = quantidade;
            this.porcentagemDesconto = porcentagemDesconto;
            this.pedido = pedido;
            this.produto = produto;
        }

        public double subTotal() {
            double desconto = produto.preco * porcentagemDesconto / 100.00;
            return (produto.preco - desconto) * quantidade;
        }

        public override string ToString() {
            return "Produto: "
                + produto.nome
                + ", Quantidade: "
                + quantidade
                + ", Porcentagem % "
                + porcentagemDesconto.ToString("F1", CultureInfo.InvariantCulture)
                + "%, Subtotal: "
                + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
