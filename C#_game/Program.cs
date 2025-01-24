using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float energia;
            bool propulsorIzquierdo, propulsorDerecho;

            Console.Write("Ingrese el nivel de energia: ");
            energia = Convert.ToSingle(Console.ReadLine());

            Console.Write("El propursor derecho esta en buene stado? (true/false)");
            propulsorDerecho = Convert.ToBoolean(Console.ReadLine());

            Console.Write("El propursor izquierdo esta en buene stado? (true/false)");
            propulsorIzquierdo = Convert.ToBoolean(Console.ReadLine());

            if(((((propulsorDerecho) && (propulsorIzquierdo)) == true) && (energia >= 75)) ||
                    ((((propulsorDerecho || propulsorIzquierdo)) == true) && (energia >= 100)))
                    {
                Console.WriteLine("Puedes despegar");
                     }   
            else
            {
                Console.WriteLine("aborte mision");
            }

        }
    }
}
