using System;

namespace Metodos_Practica2
{
    internal class Program
    {
        //Metodo Main
        static void Main()
        {
            Console.WriteLine("Que operacion desea realizar");
            Console.WriteLine("  1. Sumar  2. Multiplicar");
            int res = Convert.ToInt32(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Console.WriteLine("Ingrese el primer valor");
                    int Num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo valor");
                    int Num2 = Convert.ToInt32(Console.ReadLine());

                    Sumar(Num1, Num2);
                    break;

                case 2:
                    Console.WriteLine("Ingrese el numero de la multiplicacion");
                    int Num = Convert.ToInt32(Console.ReadLine());
                    Multiplicar(Num);
                    break;

                default:
                    Console.WriteLine("Seleccione una opcion valida");
                    break;
            }

            Console.ReadKey();
        }

        //Metodo para sumar
        static void Sumar(int Num1, int Num2)
        {
            int result = Num1 + Num2;
            Console.WriteLine("La suma es: " + result);
        }

        //Metodo para restar
        static void Multiplicar(int Num)
        {
            for (int i = 1; i<= 10; i++)
            {
                Console.WriteLine(Num + " x " + i + " = " + (Num * i));
            }
        }
    }
}
