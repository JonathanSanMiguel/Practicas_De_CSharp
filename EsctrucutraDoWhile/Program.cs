using System;
namespace EsctrucutraDoWhile
{
    internal class Program
    {
        static void Main()
        {
            int Opcion;
            do 
            {
                Console.WriteLine("Desea seguir viendo este mensaje?");
                Console.WriteLine("1.Si   2.No");
                Opcion = Convert.ToInt32(Console.ReadLine());

            } while (Opcion == 1);
            Console.ReadKey();
        }
    }
}
