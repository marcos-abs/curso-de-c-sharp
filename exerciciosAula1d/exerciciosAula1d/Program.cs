using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            double a, b, c;

            Console.WriteLine("Digite as 3 distâncias com pontos decimais (não vírgulas) na mesma linha separados com espaços:");
            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (a >= b && a >= c) {
                Console.WriteLine(a.ToString("F2", CultureInfo.InvariantCulture));
            } else if (b >= a && b >= c) {
                Console.WriteLine(b.ToString("F2", CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine(c.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
