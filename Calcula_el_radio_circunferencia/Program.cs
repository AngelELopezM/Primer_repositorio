using System;

namespace Calcula_el_radio_circunferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este es un programa que calcula la circunferencia de un circulo \n Digite la circunferencia");

            double circunferencia, radio;
            circunferencia = Convert.ToDouble(Console.ReadLine());
            radio = circunferencia / (2 * Math.PI);

            Console.WriteLine("El radio de su circulo es: "+ radio);

            Console.ReadKey();
        }
    }
}
