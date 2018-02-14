using System;

namespace atividadesExerciciosDeFixacaoSecao3Aula34 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos aluguéis serão registrados? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Estudante[] quartos = new Estudante[10];

            for (int seq = 1; seq <= qtdQuartos; seq++) {
                Console.WriteLine("Dados do " + seq + "º aluguel:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int pos = int.Parse(Console.ReadLine());
                quartos[pos] = new Estudante(nome, email);
            }
            Console.WriteLine('\n' + "Quartos ocupados:");

            for (int seq = 0; seq < 10; seq++) {
                if(quartos[seq] != null) {
                    Console.WriteLine(seq + ": " + quartos[seq]);
                }
            }

            Console.WriteLine('\n' + "Pressione Enter para finalizar");
            Console.ReadLine();
        }
    }
}
