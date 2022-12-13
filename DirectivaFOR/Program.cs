using System;
namespace DirectivaFOR
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("Cuantas veces desea imprimir la palabra, HOLA?");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //  Console.WriteLine(i + " Hola");
            //}

            Console.Write("Cual Tabla de multiplicar desea imprimir? ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }

            Console.ReadKey();
        }
    }
}