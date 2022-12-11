using System;

namespace EstructuraSelectivaSWITCH
{
    internal class Program
    {
        static void Main()
        {
            int Dia;

            Console.WriteLine("Ingrese el numero del dia (1-7)" );
            Dia = Convert.ToInt16(Console.ReadLine());

            switch(Dia) { 
                case 1:
                    Console.WriteLine("El dia es LUNES");
                    break;

                case 2:
                    Console.WriteLine("El dia es MARTES");
                    break;

                case 3:
                    Console.WriteLine("EL dia es MIERCOLES");
                    break;

                case 4:
                    Console.WriteLine("El dia es JUEVES");
                    break;

                case 5:
                    Console.WriteLine("El dia es VIERNES");
                    break;

                case 6:
                    Console.WriteLine("El dia es SABADO");
                    break;

                case 7:
                    Console.WriteLine("El dia es DOMINGO");
                    break;
                default: 
                    Console.WriteLine("Ingrese un numero entre el 1 y el 7");
                    break;
            }
            Console.ReadKey();
        }
    }
}
