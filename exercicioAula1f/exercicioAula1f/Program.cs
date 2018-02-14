using System;

namespace curso {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um valor inteiro para calcular e 0 para sair:");
            int a = int.Parse(Console.ReadLine());
            while (a != 0) {
                Console.WriteLine("Resultado=" + a * a);
                Console.WriteLine("Digite um valor inteiro para calcular e 0 para sair:");
                a = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
