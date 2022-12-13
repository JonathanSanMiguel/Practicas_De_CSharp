using System;
namespace EstructuraWhile
{
    internal class Program
    {
        static void Main()
        {
            int Correlactivo;

            Correlactivo = 0;
            Console.WriteLine("La tabla #5");

            while ( Correlactivo <= 12 )
            {
                Console.WriteLine("5 x " + Correlactivo + " = " + (5 * Correlactivo));
                Correlactivo++;
            }
            Console.ReadKey();
        }
    }
}
