using System;
using System.Globalization;

namespace aulaSecao3Aula29 {
    class ContaBancaria {
        private int numConta;
        private string nomTitularConta;
        private double valSaldoConta;

        public void cadastrarContaBancaria(int numConta, string nomTitularConta, double deposito) {
            this.numConta = numConta;
            this.nomTitularConta = nomTitularConta;
            this.valSaldoConta = deposito;
        }

        public void cadastrarContaBancaria(int numConta, string nomTitularConta) {
            this.numConta = numConta;
            this.nomTitularConta = nomTitularConta;
            this.valSaldoConta = 0;
        }

        public void depositarContaBancaria(double deposito) {
            this.valSaldoConta = this.valSaldoConta + deposito;
        }

        public void sacarContaBancaria(double retirada) {
            this.valSaldoConta = this.valSaldoConta - retirada - 5.00;
        }

        public double verSaldoContaBancaria() {
            return this.valSaldoConta;
        }

        public override string ToString() {
            return "Conta "
                + numConta
                + ", Titular: "
                + nomTitularConta
                + ", Saldo: "
                + valSaldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
