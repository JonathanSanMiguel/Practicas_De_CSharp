using System;
namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main()
        {
            int a, b, c, d;
            bool result;

            a = 10;
            b = 20;
            c = 30;
            d = 31;

            //result = (a == b) && (c < d);
            //result = (a == b) || (c > d);
            result = !(a == b);


            Console.WriteLine("resultado de: (a == b) && (c > d) " + result);
            Console.ReadKey();
        }
    }
}
