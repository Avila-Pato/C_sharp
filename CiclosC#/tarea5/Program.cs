namespace tarea5
{
    internal class Program
    {
        static void Main(string[] args)
        // Hacer un programa que calcule los numeros primos que existen entre el 1 y el 100

        {
            // Variables
            int numero, divisor, numeroDivisores = 0;

            // Ciclo para recorrer los numeros del 2 al 100

            for (numero = 2; numero <= 100; numero++)
            {
                // Ciclo para recorrer los divisores del numero
                for (divisor = 1; divisor <= numero; divisor++)
                {
                    if(numero % divisor == 0)
                    {
                        numeroDivisores++; // Si el residuo es 0, incrementa el contador de divisores
                    } 

                }
                // verificamos que el numero de divisiores sea igual a 2
                if(numeroDivisores <= 2)
                {
                    Console.WriteLine("El número {0} es primo", numero);
                }
                // REINICIAMOS EL CONTADOR DE DIVISORES
                numeroDivisores = 0;
                Console.ReadKey();
            }
        }
}
