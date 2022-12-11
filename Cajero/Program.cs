using System;
namespace Cajero
{
    internal class Program
    {
        static void Main()
        {
            decimal saldoTotal = 5000;
            int end;
            do
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|   BIENVENIDO AL CAJERO ATM     |");
                Console.WriteLine("| Que Movimiento desea realizar? |");
                Console.WriteLine("|                                |");
                Console.WriteLine("|1. Ver Saldo Actual.            |");
                Console.WriteLine("|2. Realizar un Retiro.          |");
                Console.WriteLine("|3. Realizar un Deposito.        |");
                Console.WriteLine("|4. Salir.                       |");
                Console.WriteLine("----------------------------------");
                int resp = Convert.ToInt16(Console.ReadLine());
                switch (resp)
                {
                    case 1:
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Su saldo Actual es: " + saldoTotal);
                        break;
                    case 2:
                        int reIfCon;
                        do 
                        {
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("Ingrese la Cantidad que desea retirar");
                            decimal CantRetiro = Convert.ToDecimal(Console.ReadLine());
                            if (CantRetiro > saldoTotal)
                            {
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("No Tiene Suficiente Dinero En Su Cuenta");
                                Console.WriteLine("Su Dinero Actual: " + saldoTotal);
                                reIfCon = 1;
                            }
                            else
                            {
                                saldoTotal -= CantRetiro;
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("'Transaccion existosa'");
                                Console.WriteLine("Saldo Actual: " + saldoTotal);
                                reIfCon = 2;
                            }
                        } while(reIfCon == 1);
                        break;
                    case 3:
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Ingrese la cantidad que desea Depositar");
                        decimal deposito = Convert.ToDecimal(Console.ReadLine());
                        if(deposito >= 15000)
                        {
                            Console.WriteLine("*Va a tener que declarar impuestos*");
                        }
                        saldoTotal += deposito;
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("'Transaccion Existosa'");
                        Console.WriteLine("Saldo Actual: " + saldoTotal);
                        break;
                    case 4:
                        end = 2;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Desea realizar Otra Operacion");
                Console.WriteLine("1.Si  2.No");
                end = Convert.ToInt16(Console.ReadLine());
            }
            while (end == 1);
            Console.WriteLine("---------------------");
            Console.WriteLine("Que tenga un buen dia");
            Console.WriteLine("---------------------");
            Console.ReadKey();
        }
    }
}