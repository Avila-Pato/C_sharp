using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadenas
{
    public class LittleGame
    {
        public static void Main(string[] args)
        {
            string numero = "1234";
            //Write se sua mas que anda para escribir en la misma linea
             Console.Write("Memoriza el siguiete numero: " + numero);
             // WriteLine se usa para escribir en una nueva linea
             Console.WriteLine("Presiona enter cuando estes listo");
             // ReadKey se usa para esperar a que el usuario presione una tecla
             Console.ReadKey();
             // Clear se usa para limpiar la pantalla
             Console.Clear();

             Console.Write("Ingresa el numero, probemos que tan buena es tu memoria: ");
             // ReadLine se usa para leer lo que el usuario escriba en la consola
             string respuesta = Console.ReadLine();

             //Condicion

             if(respuesta == numero)
             {
                Console.WriteLine("Felicidades, tu memoria es buena");
             }
             else
             {
                Console.WriteLine("Lo siento, tu memoria no es tan buena");
             }
        }
    }
}