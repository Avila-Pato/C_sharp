using System;

// Programa para calcular el costo del estacionamiento según el tiempo de permanencia.
namespace PrecioServicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float PrecioServicios; // Aquí declaramos correctamente la variable como tipo float.

            Console.Write("Ingrese el tiempo que ha permanecido en el estacionamiento (en minutos): ");

            // Convertimos el valor ingresado por el usuario a un número flotante.
            if (float.TryParse(Console.ReadLine(), out PrecioServicios))
            {
                if (PrecioServicios >= 0 && PrecioServicios <= 60)
                {
                    Console.WriteLine("El precio a pagar es de $5.00");
                }
                else if (PrecioServicios > 60 && PrecioServicios <= 120)
                {
                    Console.WriteLine("El precio a pagar es de $15.00");
                }
                else if (PrecioServicios > 120)
                {
                    Console.WriteLine("El precio a pagar es de $40.00");
                }
                else
                {
                    Console.WriteLine("El tiempo ingresado no es válido.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }
    }
}
