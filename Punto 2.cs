using System;

namespace Taller__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorNinos = 0;
            int contadorJovenes = 0;
            int contadorAdultos = 0;
            int contadorViejos = 0;

            double sumaPesoNinos = 0;
            double sumaPesoJovenes = 0;
            double sumaPesoAdultos = 0;
            double sumaPesoViejos = 0;

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Ingrese la edad de la persona {i + 1}:");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Ingrese el peso de la persona {i + 1}:");
                double peso = Convert.ToDouble(Console.ReadLine());
                if (edad < 18)
                {
                    contadorNinos++;
                    sumaPesoNinos += peso;
                }
                else if (edad < 30)
                {
                    contadorJovenes++;
                    sumaPesoJovenes += peso;
                }
                else if (edad < 60)
                {
                    contadorAdultos++;
                    sumaPesoAdultos += peso;
                }
                else
                {
                    contadorViejos++;
                    sumaPesoViejos += peso;
                }
            }
            double promedioPesoNinos = sumaPesoNinos / contadorNinos;
            double promedioPesoJovenes = sumaPesoJovenes / contadorJovenes;
            double promedioPesoAdultos = sumaPesoAdultos / contadorAdultos;
            double promedioPesoViejos = sumaPesoViejos / contadorViejos;

            Console.WriteLine("Promedio de peso de niños: " + promedioPesoNinos);
            Console.WriteLine("Promedio de peso de jóvenes: " + promedioPesoJovenes);
            Console.WriteLine("Promedio de peso de adultos: " + promedioPesoAdultos);
            Console.WriteLine("Promedio de peso de viejos: " + promedioPesoViejos);

            Console.ReadLine(); 
        }
    }
}
