namespace tarea4
{
    internal class Program
    {
        static void Main(string[] args)
        // Hacer un programa que calcule la potencia, ya sea negativa o positiva de cualqueir exponente
        {
            // Variables 
            int numero, exponente, i;
            numero = Convert = 1, resultadoNegativo;

            // Pedidos la base
            Console.Write("Ingrese la base: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // Pedimos el exponente
            Console.Write("Ingrese el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            // validadndo exponente del signo del exponente
            if (exponente < 0)
            {
                // Convierte el exponente a negativo multiplicado
                exponente *= -1;

                for(i = 1; <= exponente; i++)
                {
                    // el resultado se multiplica por el numero
                    resultado += numero
                }
                // asigna el resultado a negativo
                resultadoNegativo = (1 / resultado);

                // Mostramos el resultado

                Console.WriteLine("El resultado de {0} elevado a la {1} es: {2}", numero, exponente, resultadoNegativo)
            }
            else
            {
                // Si el exponente es positivo
                for (i = 1; i <= exponente; i++)
                {
                    // el resultado se multiplica por el numero
                    resultado *= numero;
                }
                // Mostramos el resultado
                Console.WriteLine("El resultado de {0} elevado a la {1} es: {2}", numero, exponente, resultado);
            }
}
