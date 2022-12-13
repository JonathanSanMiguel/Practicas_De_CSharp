using System;
namespace Vectores
{
    internal class Program
    {
        static void Main()
        {
            string[] Nombres = { "Jona", "Jesus", "Jose", "Maria", "Ana" };
      
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.WriteLine("EL nombre del vector en el indice 0 es: " + Nombres[i]);
            }

            Console.ReadKey();
        }
    }
}