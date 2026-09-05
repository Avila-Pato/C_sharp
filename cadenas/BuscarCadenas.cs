public class BuscarCadenas
{
    static void Main()
    {
        // "Contains", "StartsWith", "EndsWith", "IndexOf", "LastIndexOf", "Substring", "Replace", "ToLower", "ToUpper"
        string parrafo = "hol me llamo Pato y me gusta programar en C#";

        if(parrafo.Contains("Pato"))
        {
            Console.WriteLine("La cadena contiene la palabra Pato");
        }
        else
        {
            Console.WriteLine("La cadena no contiene la palabra Pato");
        }
        // BOOLEAN
        if(parrafo.StartsWith("hol"))
        {
            Console.WriteLine("La cadena empieza con la palabra hol");
        }
        else
        {
            Console.WriteLine("La cadena no empieza con la palabra hol");
        }

        // BOOLEAN
        if(parrafo.EndsWith("C#"))
        {
            Console.WriteLine("La cadena termina con la palabra C#");
        }
        else
        {
            Console.WriteLine("La cadena no termina con la palabra C#");
        }

        // IndexOf
        int index = parrafo.IndexOf("Pato");
        Console.WriteLine("El indice de la palabra Pato es: " + index);

        // LastIndexOf
        index = parrafo.LastIndexOf("Pato");
        Console.WriteLine("El ultimo indice de la palabra Pato es: " + index);

        // Substring // me va a entrar 3 caracteres //hol
        string subcadena = parrafo.Substring(0, 3);
        Console.WriteLine("La subcadena es: " + subcadena);

        // Replace
        string nuevaCadena = parrafo.Replace("Pato", "Gato");
        Console.WriteLine("La nueva cadena es: " + nuevaCadena);

        // ToLower
        string minusculas = parrafo.ToLower();
        Console.WriteLine("La cadena en minusculas es: " + minusculas);

        // ToUpper
        string mayusculas = parrafo.ToUpper();
        Console.WriteLine("La cadena en mayusculas es: " + mayusculas);

        // Trim
        string texto_original = "   Hola Mundo ";
        string texto_sin_espacios = texto_original.Trim();
        Console.WriteLine("Texto original: '" + texto_original + "'");

        

    }
}