using System;
using System.Collections.Generic;
using System.Globalization;

namespace atividadesPropostasSecao3Exercicio1 {

    /* 
     * Classe responsavel por conter operações que interagem com o usuário
     * no modo console
    */

    class Tela {
        public static void mostrarMenu() {
            Console.WriteLine("1 - Listar artistas ordenadamente");
            Console.WriteLine("2 - Cadastrar artista");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opção: ");
        }

        public static void mostrarArtistas() {
            Console.WriteLine("LISTAGEM DE ARTISTAS:");
            for (int i = 0; i < Program.artista.Count; i++) {
                Console.WriteLine(Program.artista[i]);
            }
            Console.WriteLine();
        }

        public static void cadastrarArtista() {
            Console.WriteLine("Digite os dados do artista: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do cachê: ");
            double cache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Artista A = new Artista(codigo, nome, cache);
            Program.artista.Add(A);
            Program.artista.Sort();
        }

        public static void cadastrarFilme() {
            Console.WriteLine("Digite os dados do filme: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Filme F = new Filme(codigo, titulo, ano);
            Console.Write("Quantas participações tem o filme? ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++) {
                Console.WriteLine("Digite os dados da " + i + "º participação:");
                Console.Write("Artista (código): ");
                int codArtista = int.Parse(Console.ReadLine());
                int pos = Program.artista.FindIndex(z => z.codigo == codArtista);
                if (pos == -1) {
                    throw new ModelException("Código do artista não encontrado: " + codArtista);
                }
                Console.Write("Valor do desconto: ");
                double descont = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Participacao P = new Participacao(descont, Program.artista[pos], F);
                F.partFilme.Add(P);
            }
            Program.filme.Add(F);
        }

        public static void mostrarFilme() {
            Console.Write("Digite o código do filme: ");
            int codFilme = int.Parse(Console.ReadLine());
            int pos = Program.filme.FindIndex(x => x.codigo == codFilme);
            if (pos == -1) {
                throw new ModelException("Código de filme não encontrado: " + codFilme);
            }
            Console.WriteLine(Program.filme[pos]);
            Console.WriteLine();
        }
    }
}
