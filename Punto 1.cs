using System;

namespace Taller__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de votos para el candidato 1: ");
            int votosCandidato1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número de votos para el candidato 2: ");
            int votosCandidato2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número de votos para el candidato 3: ");
            int votosCandidato3 = Convert.ToInt32(Console.ReadLine());

            int[] votos = new int[] { votosCandidato1, votosCandidato2, votosCandidato3 };

            int totalVotos = 0;

            foreach (int voto in votos)
            {
                totalVotos += voto;
            }

            int maxVotos = 0;
            int indiceGanador = 0;
            for (int i = 0; i < votos.Length; i++)
            {
                if (votos[i] > maxVotos)
                {
                    maxVotos = votos[i];
                    indiceGanador = i + 1;
                }
            }

            double porcentajeGanador = ((double)maxVotos / totalVotos) * 100;
            double porcentajeCandidato1 = ((double)votosCandidato1 / totalVotos) * 100;
            double porcentajeCandidato2 = ((double)votosCandidato2 / totalVotos) * 100;
            double porcentajeCandidato3 = ((double)votosCandidato3 / totalVotos) * 100;

            Console.WriteLine("Candidato ganador: Candidato " + indiceGanador);
            Console.WriteLine("Cantidad de votos: " + maxVotos);
            Console.WriteLine("Porcentaje de votos del ganador: " + porcentajeGanador.ToString("0.00") + "%");
            Console.WriteLine("Porcentaje de votos del candidato 1: " + porcentajeCandidato1.ToString("0.00") + "%");
            Console.WriteLine("Porcentaje de votos del candidato 2: " + porcentajeCandidato2.ToString("0.00") + "%");
            Console.WriteLine("Porcentaje de votos del candidato 3: " + porcentajeCandidato3.ToString("0.00") + "%");

            Console.ReadLine();
        }
    }
}
