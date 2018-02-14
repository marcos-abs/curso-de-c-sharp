using System;
using System.Globalization;

namespace atividadesExerciciosDeFixacaoSecao3Aula38 {
    class Funcionario {
        public int cpf { get; set; }
        public string nome { get; set; }
        public double salario { get; set;  }

        public Funcionario(int cpf,  string nome, double salario) {
            this.cpf = cpf;
            this.nome = nome;
            this.salario = salario;
        }

        public void aumentarSalario(double porcentagem) {
            salario = porcentagem * salario / 100.0 + salario;
        }

        public override string ToString() {
            return "CPF: " 
                + cpf
                + ", Nome: "
                + nome
                + ", Salário: "
                + salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
