using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            int a, b, c, d;

            Console.WriteLine("Digite os 2 valores inteiros relativos a altura e a largura da foto na mesma linha separados com espaços:");
            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            Console.WriteLine("Digite os 2 valores inteiros relativos a altura e a largura da porta-retrato na mesma linha separados com espaços:");
            vet = Console.ReadLine().Split(' ');
            c = int.Parse(vet[0]);
            d = int.Parse(vet[1]);

            if ((a > c || a > d) && (b > c || b > d)) {
                Console.WriteLine("NAO");
            } else {
                Console.WriteLine("SIM");
            }

            Console.ReadLine();
        }
    }
}
