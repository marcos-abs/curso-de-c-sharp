using System;

namespace curso {
    class Retangulo {
        public double largura, altura;

        public double area() {
            return largura * altura;
        }

        public double perimetro() {
            return (largura + altura) * 2;
        }

        public double diagonal() {
            return Math.Sqrt(largura * largura + altura * altura);
        }
    }
}
