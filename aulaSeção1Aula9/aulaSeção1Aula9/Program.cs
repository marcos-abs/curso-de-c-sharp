using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            string x;
            int y;
            double z;

            string[] vet = Console.ReadLine().Split(' ');

            x = vet[0];
            y = int.Parse(vet[1]);
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            
            Console.ReadLine();
        }
    }
}
