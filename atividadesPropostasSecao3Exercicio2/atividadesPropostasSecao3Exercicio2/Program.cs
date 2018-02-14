using System;
using System.Collections.Generic;
using atividadesPropostasSecao3Exercicio2.Modulos;

namespace atividadesPropostasSecao3Exercicio2 {
    class Program {

        public static List<Carro> carros = new List<Carro>();
        public static List<Marca> marcas = new List<Marca>();

        static void Main(string[] args) {

            int opcao = 0;

            // INICIANDO AS MARCAS:
            Marca m1 = new Marca(1001, "Volkswagen", "Alemanha");
            Marca m2 = new Marca(1002, "General Motors", "Estados Unidos");

            // INICIANDO OS CARROS
            Carro c1 = new Carro(101, "Fusca", 1980, 5000.00, m1);
            m1.addCarro(c1);
            Carro c2 = new Carro(102, "Golf", 2016, 60000.00, m1);
            m1.addCarro(c2);
            Carro c3 = new Carro(103, "Fox", 2017, 30000.00, m1);
            m1.addCarro(c3);
            Carro c4 = new Carro(104, "Cruze", 2016, 30000.00, m2);
            m2.addCarro(c4);
            Carro c5 = new Carro(105, "Cobalt", 2015, 25000.00, m2);
            m2.addCarro(c5);
            Carro c6 = new Carro(106, "Cobalt", 2017, 35000.00, m2);
            m2.addCarro(c6);

            // ARMAZENANDO AS MARCAS E CARROS NAS LISTAS LOCAIS DO PROGRAMA:
            marcas.Add(m1);
            marcas.Add(m2);
            carros.Add(c1);
            carros.Add(c2);
            carros.Add(c3);
            carros.Add(c4);
            carros.Add(c5);
            carros.Add(c6);

            //carros.Sort();

            while (opcao != 7) {
                Telas.mostrarOpcoes();
                try {
                    opcao = int.Parse(Console.ReadLine());
                } catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                Console.WriteLine();

                if (opcao == 1) {
                    Telas.mostrarMarcas();
                } else if (opcao == 2) {
                    Telas.mostrarCarrosDeUmaMarca();
                } else if (opcao == 3) {
                    try {
                        Telas.cadastrarMarca();
                    } catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                } else if (opcao == 4) {
                    try {
                        Telas.cadastrarCarro();
                    } catch (ModelException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    } catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                } else if (opcao == 5) {
                    try {
                        Telas.cadastrarAcessorio();
                    } catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                } else if (opcao == 6) {
                    try {
                        Telas.mostrarCarro(carros);
                    } catch (ModelException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    } catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                } else if (opcao == 7) {
                    Console.WriteLine("Fim do programa!");
                } else {
                    Console.WriteLine("Opção inválida!");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPressione ENTER para sair\n");
            Console.ReadLine();
        }
    }
}
