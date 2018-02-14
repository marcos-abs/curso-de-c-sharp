using System;
using System.Globalization;

namespace atividadesPropostasSecao2Exercicio3 {
    class Program {
        static void Main(string[] args) {
            Aluno A;
            A = new Aluno();

            Console.Write("Nome:");
            A.nome = Console.ReadLine();

            Console.Write("Nota1:");
            A.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota2:");
            A.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota3:");
            A.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final:" + A.notaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Resultado:");
            A.resultado();

            Console.WriteLine("Pressione Enter para finalizar");
            Console.ReadLine();
        }
    }
}
