using System;
namespace Metodos_Practica3
{
    internal class Program
    {
        //Metodo Main
        static void Main()
        {
            Console.WriteLine("Ingresa tu nombre ");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Cuanto te pagan por dia");
            double PagoPorDia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa los dias trabajados");
            int DiasTrabajados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hola " + Nombre);
            Console.WriteLine("Su sueldo total es: " + TotalDeDineroGanado(PagoPorDia, DiasTrabajados));

            Console.ReadKey();
        }

        //Metodo TotalDeDineroGanado
        static double TotalDeDineroGanado(double PagoPorDia, int  DiasTrabajados)
        {
            double Total = PagoPorDia * DiasTrabajados;
            return Total;
        }

    }
}
