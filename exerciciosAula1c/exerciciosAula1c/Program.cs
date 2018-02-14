using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o valor com ponto decimais (não vírgulas):");
            string texto = Console.ReadLine();

            double resultado = double.Parse(texto, CultureInfo.InvariantCulture);

            if (resultado <= 100.00) {
                Console.WriteLine("Normal");
            } else if (resultado <= 140.00) {
                Console.WriteLine("Elevado");
            } else {
                Console.WriteLine("Diabetes");
            }

            Console.ReadLine();
        }
    }
}
