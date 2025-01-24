namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ulong representa un número entero sin signo de 64 bits
            ulong i, n, factorial = 1;

            Console.Write("Ingrese un número: ");
            n = Convert.ToUInt64(Console.ReadLine());

            for(i = n; i > 0; i--)
            {
                factorial = factorial * i
            }
            Console.WriteLine("El factorial de {0} es {1}", n, factorial);
        }
    }
}
