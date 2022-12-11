using System;
namespace ConversionDeTipoDeDatos
{
    internal class Program
    {
        static void Main()
        {
            string Nombre;
            int Edad;
            bool Casado;
            double Sueldo;

            Console.Write("Ingrese su nombre ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese su edad ");
            //Edad = Convert.ToInt32(Console.ReadLine());
            Edad = int.Parse(Console.ReadLine());

            Console.Write("Estas casado? ");
            //Casado = Convert.ToBoolean(Console.ReadLine());
            Casado = bool.Parse(Console.ReadLine());

            Console.Write("Ingrese su sueldo ");
            //Sueldo= Convert.ToDouble(Console.ReadLine());
            Sueldo = double.Parse(Console.ReadLine());

            Console.Write("Su nombre es " + Nombre);
            Console.ReadKey();
        }
    }
}