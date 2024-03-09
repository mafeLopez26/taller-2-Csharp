using System;

namespace Taller__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String opcion ;
            double peso = 0.0;
            int tipoEnvio = 0;
            int destino = 0;
            double valor = 0.0;
            double total;
            do
            {
                Console.WriteLine("¿Desea repetir el ciclo? (si/no): ");
                opcion = Console.ReadLine();

                if (opcion.Equals("si", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Registrar envio");

                    Console.WriteLine("Peso del paquete (gr):");
                    peso = double.Parse(Console.ReadLine());

                    Console.WriteLine("Tipo de envio: \n1.Corriente \n2.Recomendado");
                    tipoEnvio = int.Parse(Console.ReadLine());

                    Console.WriteLine("Destino del paquete: \n1.Local \n2.Nacional \n3.Internacional");
                    destino = int.Parse(Console.ReadLine());

                    if(tipoEnvio == 1)
                    {
                        if(destino == 1)
                        {
                            valor = 100;
                            double iva = valor * 0.16;
                            total = valor + iva;
                            Console.WriteLine("Valor a cancelar: " + total);
                        }
                        else if(destino == 2)
                        {
                            valor = 150;
                            double iva = valor * 0.16;
                            total = valor + iva;
                            Console.WriteLine("Valor a cancelar: " + total);
                        }
                        else
                        {
                            valor = 200;
                            double iva = valor * 0.16;
                            total = valor + iva;
                            Console.WriteLine("Valor a cancelar: " + total);
                        }
                    }
                    else
                    {
                        if (destino == 1)
                        {
                            valor = 200;
                            double iva = valor * 0.16;
                            total = valor + iva;
                            Console.WriteLine("Valor a cancelar: " + total);
                        }
                        else if (destino == 2)
                        {
                            valor = 350;
                            double iva = valor * 0.16;
                            total = valor + iva;
                            Console.WriteLine("Valor a cancelar: " + total);
                        }
                        else
                        {
                            valor = 400;
                            double iva = valor * 0.16;
                            total = valor + iva;
                            Console.WriteLine("Valor a cancelar: " + total);
                        }

                    }
                    }

            } while (opcion.ToLower() == "si");
        }
    }
}
