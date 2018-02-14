using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            int n, volume = 0;

            do {
                Console.WriteLine("Digite o valor inteiro para o volume, sendo positivo para aumentar e negativo para diminuir:");
                n = int.Parse(Console.ReadLine());
                volume = volume + n;

                if (volume > 100) {
                    volume = 100;
                } else if (volume < 0) {
                    volume = 0;
                } 
                Console.WriteLine("Volume atual:" + volume);
            } while (n != 0);

            Console.WriteLine("Pressione Enter para finalizar");
            Console.ReadLine();
        }
    }
}
