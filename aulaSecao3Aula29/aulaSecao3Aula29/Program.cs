using System;
using System.Globalization;

namespace aulaSecao3Aula29 {
    class Program {
        static void Main(string[] args) {

            ContaBancaria CB = new ContaBancaria();
            double valor;

            Console.WriteLine("Digite os dados da conta:");
            Console.Write("Numero da conta: ");
            int numConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nome do titular da conta: ");
            string nomTitularConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?: ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 'n' || resposta == 'N') {
                CB.cadastrarContaBancaria(numConta, nomTitularConta);
            } else {
                Console.Write("Digite o valor do depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                CB.cadastrarContaBancaria(numConta, nomTitularConta, valor);
            }

            Console.WriteLine("Conta criada:");
            Console.WriteLine(CB);
            Console.Write("Digite o valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            CB.depositarContaBancaria(valor);

            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(CB);
            Console.Write("Digite o valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            CB.sacarContaBancaria(valor);

            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(CB);

            Console.WriteLine();
            Console.WriteLine("Pressione Enter para finalizar");
            Console.ReadLine();
        }
    }
}
