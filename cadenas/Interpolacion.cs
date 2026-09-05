using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadenas
{
    public class Interpolacion
    {
        public static void Main(string[] args)
        {
            double gastos = 1500.5032;
            double ingresos = 2500.75233;
            var numero = 123456789;
            Console.WriteLine($"El numero es: {numero:N0}"); // N0 -> me ayuda a ver el valor en formato de numero con separador de miles
            Console.WriteLine($"El numero es: {numero:N2}"); // N2 -> me ayuda a ver el valor en formato de numero con 2 decimales
            Console.WriteLine($"El numero es: {numero:####-####-####}"); // ####-####-#### -> me ayuda a ver el valor en formato de 
            // numero con separador de guion cada 4 digitos

            // Interpolacion de cadenas
            // C = currency -> me ayuda a ver el valor en formato de moneda
            // F = float -> me ayuda a ver el valor en formato de numero decimal
            string mensaje = $"Tus gastos son: {gastos:C} y tus ingresos son: {ingresos:F}.";

            Console.WriteLine(mensaje);
        }
    }
}