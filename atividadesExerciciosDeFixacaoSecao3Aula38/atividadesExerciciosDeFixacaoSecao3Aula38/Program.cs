using System;
using System.Collections.Generic;
using System.Globalization;

namespace atividadesExerciciosDeFixacaoSecao3Aula38 {
    class Program {
        static void Main(string[] args) {
            int cpf = 0, pos;
            string nome;
            double salario;

            Console.Write("Quantos funcionários serão cadastrados? ");
            int qtdFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int x = 1; x <= qtdFuncionarios; x++) {
                Console.WriteLine("Dados do " + x + "º funcionário: ");
                while (true) {
                    Console.Write("Digite um CPF não cadastrado: ");
                    cpf = int.Parse(Console.ReadLine());
                    pos = lista.FindIndex(z => z.cpf == cpf);
                    if (pos == -1) {
                        break;
                    } else {
                        Console.WriteLine('\n' + "Erro: CPF já cadastrado." + '\n');
                    }
                }
                Console.Write("Digite o nome do funcionário: ");
                nome = Console.ReadLine();

                Console.Write("Digite o salario do funcionário: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Funcionario(cpf, nome, salario));
            }

            Console.Write("Digite o CPF do funcionário que terá aumento: ");
            cpf = int.Parse(Console.ReadLine());
            pos = lista.FindIndex(x => x.cpf == cpf);
            if (pos > -1) {
                Console.Write("Digite a porcentagem de aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //lista[pos].salario = lista[pos].salario + (lista[pos].salario * porcentagem / 100);
                lista[pos].aumentarSalario(porcentagem);
            } else {
                Console.WriteLine('\n' + "Erro: CPF não encontrado." + '\n');
            }

            Console.WriteLine("Listagem atualizada de funcionários:" );
            for (int x = 0; x < lista.Count; x++) {
                Console.WriteLine(lista[x]);
            }

            Console.WriteLine('\n' + "Pressione Enter para finalizar");
            Console.ReadLine();
        }
    }
}
