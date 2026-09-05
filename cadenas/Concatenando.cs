public class Concatenando
{
    public static void Main(string[] args)
    {
        string nombre = "Pato";
        string apellido = "Donald";
        int edad = 30;

        // Concatenación de cadenas

        string mensaje = string.Concat(nombre, " ", apellido, " tiene ", edad, " años.");
        Console.WriteLine(mensaje);

    }
}