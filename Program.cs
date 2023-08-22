using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrismaTriangularApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadPrismas = 0;

            do
            {
                int basePrisma = PedirEnteroPositivo("Ingrese la base del prisma (ingrese 0 para terminar): ");

                if (basePrisma != 0)
                {
                    int alturaPrisma = PedirEnteroPositivo("Ingrese la altura del prisma: ");
                    int longitudPrisma = PedirEnteroPositivo("Ingrese la longitud del prisma: ");

                    int areaBase = CalcularAreaBase(basePrisma, alturaPrisma);
                    int areaLateral = CalcularAreaLateral(longitudPrisma, alturaPrisma);
                    int volumen = CalcularVolumen(areaBase, alturaPrisma);
                    double diagonal = CalcularDiagonal(basePrisma, alturaPrisma);

                    Console.WriteLine($"Área Base:  {areaBase}");
                    Console.WriteLine($"Área Lateral:  {areaLateral}");
                    Console.WriteLine($"Volumen: {volumen}");
                    Console.WriteLine($"Diagonal: {diagonal}");

                    cantidadPrismas++;
                }
            } while (true);

            Console.WriteLine($"Proceso finalizado. Cantidad de prismas ingresados:  {cantidadPrismas}");
        }

        static int PedirEnteroPositivo(string mensaje)
        {
            int valor;
            do
            {
                Console.Write(mensaje);
            } while (!int.TryParse(Console.ReadLine(), out valor) || valor < 0);

            return valor;
        }

        static int CalcularAreaBase(int basePrisma, int alturaPrisma)
        {
            return 2 * (basePrisma * alturaPrisma / 2);
        }

        static int CalcularAreaLateral(int longitudPrisma, int alturaPrisma)
        {
            return 3 * (longitudPrisma * alturaPrisma);
        }

        static int CalcularVolumen(int areaBase, int alturaPrisma)
        {
            return areaBase * alturaPrisma;
        }

        static double CalcularDiagonal(int basePrisma, int alturaPrisma)
        {
            return Math.Sqrt(Math.Pow(basePrisma, 2) + Math.Pow(alturaPrisma, 2));
        }
    }
}

