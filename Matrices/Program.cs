using System;
namespace Matrices
{
    internal class Program
    {
        static void Main()
        {
            string[,] Persona = new string[3, 3];

            Persona[0, 0] = "Jona";
            Persona[0, 1] = "jesus";
            Persona[0, 2] = "jose";

            Persona[1, 0] = "maria";
            Persona[1, 1] = "hola";
            Persona[1, 2] = "como";

            Persona[2, 0] = "estas";
            Persona[2, 1] = "yo";
            Persona[2, 2] = "bien";

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Persona["+ i +"] = " + Persona[i, 0] + " " + Persona[i, 2]);

            }

            Console.ReadKey();
        }
    }
}
