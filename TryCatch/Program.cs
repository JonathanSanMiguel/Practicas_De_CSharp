using System;
namespace TryCatch
{
    internal class Program
    {
        static void Main()
        {
            int edad;

            try
            {
                Console.WriteLine("Ingres su Edad");
                edad = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception error) 
            {
                Console.WriteLine(error.Message);
            }
                
            Console.ReadKey();
        }
    }
}