using System;

namespace Constante
{
    internal class Program
    {
        static void Main()
        {
            string Nombre;
            int Edad;
            const double Sueldo = 3000;

            dynamic Contenido;
            Contenido = 10.567;


            Nombre = "Jona";
            Edad = 23;

            Console.WriteLine("Mi nombre es: " + Nombre);
            Console.WriteLine("Mi edad es: " + Edad);
            Console.WriteLine("Mi edad es: " + Sueldo);

            Console.WriteLine("El contenido es: "  + Contenido);
            Console.ReadKey();
        }
    }
}
