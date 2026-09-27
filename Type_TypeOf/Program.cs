class Program
{
    static void Main(string[] args)
    {
        // Class "TYPE"
        // Operador "typeof"

        //Type tipoDatoEntero;

        //tipoDatoEntero = typeof(int);

        // Console.WriteLine(tipoDatoEntero);

        // Console.WriteLine($"Nombre del tipo {tipoDatoEntero}");

        //foreach (Continentes elemento in Enum.GetValues(typeof(Continentes)))
        //{
        //    Console.WriteLine(elemento);
        //    Console.ReadLine();
        //}

        int a = 10, b = 2;

        OpcionesMenu opcion;

        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division");

        Console.Write("Elige una opcion");
        opcion = (OpcionesMenu)Enum.Parse(typeof(OpcionesMenu), Console.ReadLine());

            switch (opcion)
        {
            case OpcionesMenu.Suma:
                Console.WriteLine($"{a} + {b}  =  {a + b}")
                    break;

            case OpcionesMenu.Resta:
                Console.WriteLine($"{a} - {b}  =  {a - b}")
                    break;

            case OpcionesMenu.Divission:
                Console.WriteLine($"{a} / {b}  =  {a / b}")
                    break;

            case OpcionesMenu.Multiplicacion:
                Console.WriteLine($"{a} * {b}  =  {a * b}")
                     break;
        }
    }
}

enum OpcionesMenu
{
    Suma,
    Resta,
    Multiplicacion,
    Divission
}


//enum Continentes
//{
//    Africa,
//    America,
//    Asia,
//    Europa,
//    Oceania
//}