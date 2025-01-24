using System;

// Hacer un programa que le pida un numero y decirle que si esta impar o par
namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long numero;

            Console.Write("Ingrese un número: ");
            // Convert.ToInt64() is used to convert the input
            // to a long integer
            numero = Convert.ToInt64(Console.ReadLine());

            if((numero % 2) == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }

        }
    }
}
