using System;
using System.Collections.Generic;

namespace atividadesExerciciosDeFixacao5Secao3Aula40 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos alunos possui o curso A?: ");
            int qtdAlunosCursoA = int.Parse(Console.ReadLine());

            HashSet<int> alunosCursoA = new HashSet<int>();

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int x = 0; x < qtdAlunosCursoA; x++) {
                alunosCursoA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Quantos alunos possui o curso B?: ");
            int qtdAlunosCursoB = int.Parse(Console.ReadLine());

            HashSet<int> alunosCursoB = new HashSet<int>();

            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int x = 0; x < qtdAlunosCursoB; x++) {
                alunosCursoB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Quantos alunos possui o curso C?: ");
            int qtdAlunosCursoC = int.Parse(Console.ReadLine());

            HashSet<int> alunosCursoC = new HashSet<int>();

            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int x = 0; x < qtdAlunosCursoC; x++) {
                alunosCursoC.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> alunosTodosCursos = new HashSet<int>();

            alunosTodosCursos.UnionWith(alunosCursoA);
            alunosTodosCursos.UnionWith(alunosCursoB);
            alunosTodosCursos.UnionWith(alunosCursoC);

            Console.WriteLine('\n' + "Total de alunos: " + alunosTodosCursos.Count);

            /*foreach (int x in alunosTodosCursos) {
                Console.WriteLine(x);
            }*/

            Console.WriteLine('\n' + "Pressione Enter para finalizar");
            Console.ReadLine();
        }
    }
}
