using System;
using System.Collections.Generic;

namespace atividadesPropostasSecao3Exercicio1 {
    class Program {

        public static List<Filme> filme = new List<Filme>();
        public static List<Artista> artista = new List<Artista>();

        static void Main(string[] args) {

            int opcao = 0;

            artista.Add(new Artista(102, "Chris Evans", 2500000.00));
            artista.Add(new Artista(104, "Morgan Freeman", 4000000.00));
            artista.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            artista.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            artista.Sort();
            while (opcao != 5) {
                Console.Clear();
                Tela.mostrarMenu();
                try {
                    opcao = int.Parse(Console.ReadLine());
                } catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                Console.WriteLine();

                if (opcao == 1) {
                    Tela.mostrarArtistas();
                } else if (opcao == 2) {
                    try {
                        Tela.cadastrarArtista();
                    } catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                } else if (opcao == 3) {
                    try {
                        Tela.cadastrarFilme();
                    } catch (ModelException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    } catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                } else if (opcao == 4) {
                    try {
                        Tela.mostrarFilme();
                    } catch (ModelException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    } catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                } else if (opcao == 5) {
                    Console.WriteLine("Fim do programa!");
                } else {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
