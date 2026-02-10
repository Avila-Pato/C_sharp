namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        int opcion = -1;

        do
        {
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("0. Salir");

            Console.Write("Elige una opción: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Sumar();
                        break;
                    case 2:
                        Restar();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Debes ingresar un número, no letras");
            }

            Console.WriteLine();

        } while (opcion != 0);
    }

    static void Sumar()
    {
        Console.Write("Ingrese el primer número: ");
        decimal num1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        decimal num2 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    }

    static void Restar()
    {
        Console.Write("Ingrese el primer número: ");
        decimal num1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        decimal num2 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
    }
}
