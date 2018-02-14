using System;
using System.Globalization;

namespace atividadesPropostasSecao2Exercicio2 {
    class Program {
        static void Main(string[] args) {

            double porcentagem;

            Funcionario F = new Funcionario();

            Console.Write("Nome:");
            F.nome = Console.ReadLine();

            Console.Write("Salario:");
            F.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Desconto:");
            F.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(F);

            Console.Write("Deseja aumentar o salario em qual porcentagem?:");
            porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.aumentarSalario(porcentagem);

            Console.WriteLine(F);

            Console.WriteLine("Pressione Enter para finalizar");
            Console.ReadLine();
        }
    }
}
