using System;

namespace OperadoresRelacionales
{
    internal class Program
    {
        static void Main()
        {
            int Num1, Num2;
            bool Operaciones;

            Num1= 10;
            Num2= 20;

            Operaciones = (Num1 >= Num2);

            Console.WriteLine("Num1 es mayor que Num2? " + Operaciones);
            Console.ReadKey();
        }
    }
}
