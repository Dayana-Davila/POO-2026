using System;
using System.Collections.Generic;

namespace EjemploFiguras
{
    abstract class Figura
    {
                public abstract double CalcularArea();
    }

    class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double b, double h)
        {
            Base = b;
            Altura = h;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }

    class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> listaFiguras = new List<Figura>();

            listaFiguras.Add(new Rectangulo(5, 10));
            listaFiguras.Add(new Circulo(3));
            listaFiguras.Add(new Rectangulo(2, 4));

            Console.WriteLine("Cálculo de Áreas:");
            Console.WriteLine("-----------------");

            foreach (var figura in listaFiguras)
            {
                double area = figura.CalcularArea();
                
                Console.WriteLine($"Tipo: {figura.GetType().Name} - Área: {area:F2}");
            }
        }
    }
}