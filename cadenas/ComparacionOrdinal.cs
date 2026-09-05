using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadenas
{
    public class ComparacionOrdinal
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un correo: ");
            string correo = Console.ReadLine();

            Console.Write("Ingresa tu correo nuevamente: ");
            string correoConfirmar = Console.ReadLine();

            bool coincidenCorreo;

            //Comparacion ordinal
            // Se usa para comparar cadenas evitando problemas de cultura y mayusculas/minusculas
            coincidenCorreo = string.Equals(correo, correoConfirmar, StringComparison.Ordinal);

            if (coincidenCorreo)
            {
                Console.WriteLine("Los correos coinciden");
            }
            else
            {
                Console.WriteLine("Los correos no coinciden");
            }
        }
    }
}