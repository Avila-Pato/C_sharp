namespace EjemploMemoryStream;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una cadena de texto para guardar en el Stream:");
        string mensaje = Console.ReadLine();
        string mensajeCifrado = CifrarMensaje(mensaje);
        Console.WriteLine("Mensaje cifrado: " + mensajeCifrado);
        string mensajeDescifrado = DescifrarMensaje(mensajeCifrado);
        Console.WriteLine("Mensaje descifrado: " + mensajeDescifrado);
    }

    static string CifrarMensaje(string mensajeCifrarPa)
    {
        // Variable que se va a guardar el mensaje cifrado
        string mensajeCifrado;

        // le asignamos el mensaje original a la variable mensajeCifrado
        mensajeCifrado = mensajeCifrarPa;
        // remplazamos las letras del mensaje original por otras letras para cifrarlo
        mensajeCifrado = mensajeCifrado.Replace("a", "1");

        mensajeCifrado = mensajeCifrado.Replace("e", "2");
        mensajeCifrado = mensajeCifrado.Replace("i", "3");
        mensajeCifrado = mensajeCifrado.Replace("o", "4");

        return mensajeCifrado;
    }

    static string DescifrarMensaje(string mensajeDescifrarPa)
    {
        // Variable que se va a guardar el mensaje descifrado
        string mensajeDescifrado;
        // le asignamos el mensaje original a la variable mensajeDescifrado
        mensajeDescifrado = mensajeDescifrarPa;
        // remplazamos las letras del mensaje original por otras letras para descifrarlo
        mensajeDescifrado = mensajeDescifrado.Replace("1", "a");
        mensajeDescifrado = mensajeDescifrado.Replace("2", "e");
        mensajeDescifrado = mensajeDescifrado.Replace("3", "i");
        mensajeDescifrado = mensajeDescifrado.Replace("4", "o");
        return mensajeDescifrado;

         }
}