using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            int a, b, c, resultado;

            Console.WriteLine("Digite os valores na mesma linha separados com espaços, volume do frasco*, vazão da bomba* e tempo de utilização** (*valores em ml ** valor em segundos):");
            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0], CultureInfo.InvariantCulture);
            b = int.Parse(vet[1], CultureInfo.InvariantCulture);
            c = int.Parse(vet[2], CultureInfo.InvariantCulture);

            if (b * c > a) {
                Console.WriteLine("nao eh possivel");
            } else {
                resultado = a - b * c;
                Console.WriteLine(resultado.ToString("F0", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
