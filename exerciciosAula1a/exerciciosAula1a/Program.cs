using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            double a, b, c, resultado;

            Console.WriteLine("Digite as 3 notas com pontos decimais (não vírgulas) na mesma linha separados com espaços:");
            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            resultado = a + b + c;
            Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));
            if (resultado < 60.00 ) {
                Console.WriteLine("DEPENDENCIA");
            }

            Console.ReadLine();
        }
    }
}
