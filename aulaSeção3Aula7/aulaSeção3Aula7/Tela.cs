using System;
using System.Globalization;
using curso.dominio;

namespace aulaSecao3Aula7 {
    class Tela {
        public static void mostrarMenu() {
            Console.WriteLine("Selecione a opção abaixo:");
            Console.WriteLine("1 - Listar produtos ordenadamente");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("3 - Cadastrar pedido");
            Console.WriteLine("4 - Mostrar dados de um pedido");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opção: ");
        }
        public static void mostrarProdutos() {
            Console.WriteLine("LISTAGEM DE PRODUTOS:");
            for (int i = 0; i < Program.produtos.Count; i++) {
                Console.WriteLine(Program.produtos[i]);
            }
            Console.WriteLine();
        }
        public static void cadastrarProduto() {
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto P = new Produto(codigo, descricao, preco);
            Program.produtos.Add(P);
            Program.produtos.Sort();
        }
        public static void cadastrarPedido() {
            Console.WriteLine("Digite os dados do pedido: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data do pedido: ");
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Pedido P = new Pedido(codigo, dia, mes, ano);

            Console.Write("Quantos itens tem o pedido? ");
            int N = int.Parse(Console.ReadLine());

            for (int x=1;x<=N; x++) {

                Console.WriteLine("Digite os dados do " + x + "º item: ");

                Console.Write("Produto (código): ");
                int codProduto = int.Parse(Console.ReadLine());

                int pos = Program.produtos.FindIndex(z => z.codigo == codProduto);
                if (pos == -1) {
                    throw new ModelException("Código de produto não encontrado: " + codProduto);
                }

                Console.Write("Quantidade: ");
                int qte = int.Parse(Console.ReadLine());

                Console.Write("Porcentagem de desconto: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ItemPedido ip = new ItemPedido(qte, porcent, P, Program.produtos[pos]);
                P.itens.Add(ip);
            }
            Program.pedidos.Add(P);
        }
        public static void mostrarPedido() {
            Console.Write("Digite o código do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = Program.pedidos.FindIndex(x => x.codigo == codPedido);
            if (pos == -1) {
                throw new ModelException("Código de pedido não encontrado: " + codPedido);
            }
            Console.WriteLine(Program.pedidos[pos]);
            Console.WriteLine();
        }
    }
}
