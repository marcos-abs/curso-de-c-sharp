using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            Retangulo R;
            R = new Retangulo();

            Console.WriteLine("Digite um valor com ponto decimal para altura do retângulo:");
            R.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite um valor com ponto decimal para largura do retângulo:");
            R.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area:" + R.area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro:" + R.perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal:" + R.diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Pressione Enter para finalizar");
            Console.ReadLine();
        }
    }
}
