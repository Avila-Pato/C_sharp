using System.Reflection;
using System.Reflection.Metadata;

namespace acumulador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num, num2, resultado;

            Console.Write("Ingrensa el primer valor:");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrensa el primer valor:");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //Operacion
            resultado = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
        }
    }
}
