using System;

namespace DatosPrimitivos
{
    internal class Program
    {
        static void Main()
        {
            string nombre;
            int edad;
            double estatura;
            //bool Casado;

            Console.Write("Cual es tu nombre? ");
            nombre = Console.ReadLine();

            Console.Write("Cual es tu edad? ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cual es tu estatura? ");
            estatura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Estas Casado?  ");
            Console.Write("1.Si  2.No ");
            int resp = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Tu nombre es: " + nombre);
            Console.WriteLine("Tu edad es: " + edad);
            Console.WriteLine("Tu estatura es: " + estatura);

            if(resp == 1)
            {
                Console.WriteLine("Estas casado");
            }
            else
            {
                Console.WriteLine("No estas casado");
            }

            Console.ReadKey();
        }
    }
}
