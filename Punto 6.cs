using System;

namespace Taller__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reprobados = 0;
            Console.WriteLine("Ingresa la cantidad de alumnos: ");
            int totalAlumnos= int.Parse(Console.ReadLine());
            for (int i = 1; i <= totalAlumnos; i++)
            {
                Console.WriteLine("Ingrese las calificaciones de los alumnos:");
                Console.Write($"Calificación del alumno {i}: ");
                int calificacion = int.Parse(Console.ReadLine());

                if (calificacion < 70)
                {
                    reprobados++;
                }
            }

            double porcentajeReprobados = (double)reprobados / totalAlumnos * 100;

            Console.WriteLine($"Porcentaje de reprobados: {porcentajeReprobados}%");
        }
    }
}
