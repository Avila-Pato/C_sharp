namespace multiplicador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string entrada;

            Console.Write("Ingresa un número: ");
            entrada = Console.ReadLine();

            // Intenta convertir la entrada a un número entero
            if (int.TryParse(entrada, out numero))
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i} x {numero} = {i * numero}");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }

            Console.ReadKey();
        }
    }
}
