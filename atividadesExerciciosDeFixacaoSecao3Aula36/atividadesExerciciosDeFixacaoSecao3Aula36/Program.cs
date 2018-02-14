using System;

namespace atividadesExerciciosDeFixacaoSecao3Aula36 {
    class Program {
        static void Main(string[] args) {
            int[,] mat;

            Console.Write("Digite os valores separados com espaços para Linhas (M) e Colunas (N) da matriz: ");
            string[] linha  = Console.ReadLine().Split(' ');
            int M = int.Parse(linha[0]);
            int N = int.Parse(linha[1]);

            mat = new int[M, N]; // inicialização da matriz/vetor

            for (int x = 0; x < M; x++) {
                Console.Write("Digite os valores separados com espaços linha nº " + x + ": ");
                linha = Console.ReadLine().Split(' ');
                for (int y = 0; y < N; y++) {
                    mat[x, y] = int.Parse(linha[y]);
                }
            }

            Console.Write("Digite o valor de referencia para localizar valores a esquerda/acima/direita/abaixo:");
            int X = int.Parse(Console.ReadLine());

            for (int l = 0; l < M; l++) {
                for (int c = 0; c < N; c++) {
                    if (mat[l, c] == X) {
                        if (c > 0) {
                            Console.WriteLine("Esquerda: " + mat[l, c - 1]);
                        }
                        if (l > 0) {
                            Console.WriteLine("Acima: " + mat[l - 1, c]);
                        }
                        if (c < M) {
                            Console.WriteLine("Direita: " + mat[l, c + 1]);
                        }
                        if (l < N) {
                            Console.WriteLine("Abaixo: " + mat[l + 1, c]);
                        }
                        break;
                    }
                }
            }
            
            Console.WriteLine('\n' + "Pressione Enter para finalizar");
            Console.ReadLine();
        }
    }
}
