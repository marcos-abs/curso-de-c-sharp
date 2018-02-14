using System;

namespace curso {
    class Program {
        static void Main(string[] args) {

            int a, b, soma = 0;

            Console.WriteLine("Digite os 2 valores inteiros na mesma linha separados com espaços, sendo o primeiro menor ou igual ao segundo:");
            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            for(int x = a; x <= b; x++) {
                if(x % 2 != 0) {
                    soma = soma + x;
                }
            }

            Console.WriteLine(soma);

            Console.ReadLine();
        }
    }
}
