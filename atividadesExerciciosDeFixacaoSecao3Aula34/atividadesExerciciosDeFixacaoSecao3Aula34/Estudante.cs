namespace atividadesExerciciosDeFixacaoSecao3Aula34 {
    class Estudante {
        public string nome { get; set; }
        public string email { get; set; }

        public Estudante(string nome, string email) {
            this.nome = nome;
            this.email = email;
        }

        public override string ToString() {
            return "Nome: "
                + nome
                + ", Email: "
                + email;
        }
    }
}
