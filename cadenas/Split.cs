public class Split
{
    static void Main()
        // Punto de entrada del programa

        // static
            // Indica que peude ejecutarse main
            // sin nececidad de crear un objeto
        // void
            // Indica que no devuelve ningun valor
            //Ejemplo 
        //Void Saludar()
        // {
                // Console.WriteLine("Hola");
                //No retorna nada
        // }

        // string[] args
            // Es un array de cadenas
            // Los argumentos de la linea de comandos
            // ejemplo 
            // dotnet run Hola Pato
            // Console.WriteLine(args[0]);
            // Console.WriteLine(args[1]);
            // Si ejecutamos el programa con el argumento "Hola Pato"

    {
        string parrafo = "Hola Mundo";

        // Division de cadenas
        string[] palabras = parrafo.Split(' ');
        // Console.WriteLine("Parrafo: " + parrafo);
        // Console.WriteLine("Palabras: " + palabras.Length);
        // Console.WriteLine(palabras[0]);
        // Console.WriteLine(palabras[1]);

        foreach(string palabra in palabras)
        {
            Console.WriteLine(palabra);
        }
    }
}