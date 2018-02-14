using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            int n;

            double a, b, c, totNotas;

            string[] vet;
            
            Console.WriteLine("Digite a quantidade de alunos:");
            string s = Console.ReadLine();
            n = int.Parse(s);

            for (int x = 0; x < n; x++) {
                Console.WriteLine("Digite as 3 notas do aluno(" + (x + 1) + ") com pontos decimais (não vírgulas) na mesma linha separados com espaços");
                vet = Console.ReadLine().Split(' ');
                a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                c = double.Parse(vet[2], CultureInfo.InvariantCulture);
                totNotas = a + b + c;
                Console.WriteLine(totNotas.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("Pressione Enter para finalizar");
            Console.ReadLine();
        }
    }
}
