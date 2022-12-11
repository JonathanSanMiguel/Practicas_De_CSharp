using System;

namespace DirectivaIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Sueldo;

            Console.WriteLine("Ingrese su sueldo");
            Sueldo = Convert.ToDouble(Console.ReadLine());

            if (Sueldo >= 15000) 
            {
                Console.WriteLine("Si necesitara pagar impuestos");
                Console.WriteLine(Sueldo);
            }
            else if (Sueldo == 10000 || Sueldo < 1000) 
            {
                Console.WriteLine("Las transacciones de 10,000 exactos o menos de 1,000 No pagan impuestos");
            }
            else
            {
                Console.WriteLine("Necesitara pagar ");
            }
 
            Console.ReadKey();
        }
    }
}
