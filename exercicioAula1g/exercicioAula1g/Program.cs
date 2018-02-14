using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            double totHoras, tempoJogo;
            int numVezes;

            Console.WriteLine("Digite um valor para Total de horas com a bateria carregada:");
            totHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite um valor inteiro para quantidade de horas:");
            numVezes = int.Parse(Console.ReadLine());

            for (int x = 0; x < numVezes; x++) {
                Console.WriteLine("Digite um valor do tempo(" + (x + 1) + "):");
                tempoJogo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                totHoras = totHoras - tempoJogo;
                if(totHoras >= 0) {
                    Console.WriteLine(totHoras.ToString("F1", CultureInfo.InvariantCulture));
                } else {
                    Console.WriteLine("recarregar");
                }
            }

            Console.WriteLine("Pressione Enter para finalizar");
            Console.ReadLine();
        }
    }
}
