using System;

// Hacer un programa que le pida al usuario un numero del 1 al 12 y muestre el mes correspondiente.

namespace TaskProject 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte mes;

            Console.Write("Ingrese el número del mes que quieres conocer: ");
            mes = byte.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Este mes no existe");
                    break;
            }
           
                Console.WriteLine("Fin del programa presiona una tecla para salir...");
                Console.ReadKey(); // Evita que la consola se cierre inmediatamente
            
        }
    }
}
