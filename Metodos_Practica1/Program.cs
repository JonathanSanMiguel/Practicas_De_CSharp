using System;

namespace Metodos_Practica1
{
    internal class Program
    {
        //Metodo Main
        static void Main()
        {
            IngresoDatos();
            Console.ReadKey();
        }

        //Metodo Ingreso Datos
        static void IngresoDatos()
        {
            string Nombre;
            Console.WriteLine("Ingrese su nombre");
            Nombre = Console.ReadLine();

            Console.WriteLine("Tu nombre es: " + Nombre);
        }

    }



}
