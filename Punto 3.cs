using System;

namespace Taller__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precioPorKilo = 5.0;
            double descuento = 0.15;
            double montoTotal = 0.0;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Ingrese la cantidad de kilos comprados por el cliente {i + 1}:");
                double kilosComprados = Convert.ToDouble(Console.ReadLine());

                double montoCliente = kilosComprados * precioPorKilo;

                if (kilosComprados > 10)
                {
                    montoCliente -= montoCliente * descuento;
                }

                montoTotal += montoCliente;

                Console.WriteLine($"El cliente {i + 1} deberá pagar: {montoCliente} pesos.");
            }

            Console.WriteLine($"El monto total percibido por la tienda es: {montoTotal} pesos.");

            Console.ReadLine();
        }
    }
}
