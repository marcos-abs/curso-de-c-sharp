using System;
using System.Globalization;

namespace atividadesPropostasSecao2Exercicio3 {
    class Aluno {
        public string nome;
        public double nota1, nota2, nota3;
        
        public double notaFinal() {
            return nota1 + nota2 + nota3;
        }

        public void resultado() {
            if(notaFinal() >= 60.00) {
                Console.WriteLine("Aprovado");
            } else {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltam " + (60 - notaFinal()).ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            }
        }
    }
}
