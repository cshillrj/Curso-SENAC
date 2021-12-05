using System;

namespace atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
           double raio;


            Console.Write("Informe o valor do raio:");
            raio = double.Parse(Console.ReadLine());
            double total = Area(raio);
            Console.WriteLine($"A área do círculo vale: {total} ");
        }

           static double Quadrado(double numero)
        {
            double quadrado = numero * numero;
            return quadrado;
        }

        static double Area(double raio)
        {
            double area = 3.14 * Quadrado(raio);
            return area; 
        }
    }
}
 