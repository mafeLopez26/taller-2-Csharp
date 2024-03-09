using System;

namespace Taller__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int amarilla = 0, rosa = 0, roja = 0, verde = 0, azul = 0;

            do
            {
                Console.Write("Ingrese el último dígito de la placa (0 para terminar): ");
                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                    case 2:
                        amarilla++;
                        break;
                    case 3:
                    case 4:
                        rosa++;
                        break;
                    case 5:
                    case 6:
                        roja++;
                        break;
                    case 7:
                    case 8:
                        verde++;
                        break;
                    case 9:
                    case 0:
                        azul++;
                        break;
                    default:
                        Console.WriteLine("Dígito no válido.");
                        break;
                }
            } while (n != 0);

            Console.WriteLine("Cantidad de autos por color de calcomanía:");
            Console.WriteLine("Amarilla: " + amarilla);
            Console.WriteLine("Rosa: " + rosa);
            Console.WriteLine("Roja: " + roja);
            Console.WriteLine("Verde: " + verde);
            Console.WriteLine("Azul: " + azul);
        }
    }
}
