using System;
using System.IO;
using System.Text;

namespace FlujoMemoria;

class Program
{
    static void Main(string[] args)
    {
        // Creamos un Stream para trabajar con la memoria RAM
        MemoryStream ms1 = new MemoryStream(3);

        // Mostramos información inicial del Stream
        InformacionStream(ms1);

        // Pedimos una cadena al usuario
        Console.WriteLine("Ingrese una cadena de texto para guardar en el Stream:");
        string cadena1 = Console.ReadLine();

        // Convertimos el string en una secuencia de bytes
        byte[] matrizCadena = Encoding.UTF8.GetBytes(cadena1);

        // Escribimos los bytes dentro del Stream
        ms1.Write(matrizCadena, 0, matrizCadena.Length);

        // Mostramos información después de guardar los datos
        InformacionStream(ms1);

        // Cambiamos la posición del Stream al byte 5
        ms1.Seek(5, SeekOrigin.Begin);

        Console.WriteLine(
            "La posición del Stream después de saltar 5 bytes es: "
            + ms1.Position + " bytes"
        );

        // Nueva matriz de bytes para guardar la codificación de una cadena
        byte[] matrizCadena2 = Encoding.UTF8.GetBytes("Hola mundo");

        // Escribimos la nueva cadena desde la posición 5
        ms1.Write(matrizCadena2, 0, matrizCadena2.Length);

        // Mostramos información después de guardar la nueva cadena
        Console.WriteLine("Después de guardar la nueva cadena:");
        InformacionStream(ms1);

        // Volvemos a la posición 5 para comenzar a leer desde ahí
        ms1.Seek(5, SeekOrigin.Begin);

        // Buffer para almacenar los bytes leídos por Read
        byte[] buferBytesLeidos = new byte[100];

        // Leemos el contenido del Stream
        int bytesLeidos = ms1.Read(
            buferBytesLeidos,
            0,
            buferBytesLeidos.Length
        );

        Console.WriteLine(
            "Se leyeron " + bytesLeidos + " bytes del Stream"
        );

        // Decodificamos los bytes leídos a string
        string cadenaLeida = Encoding.UTF8.GetString(
            buferBytesLeidos,
            0,
            bytesLeidos
        );

        Console.WriteLine(
            "La cadena leída del Stream es: " + cadenaLeida
        );
    }

    static void InformacionStream(MemoryStream ms1)
    {
        Console.WriteLine(
            "La capacidad del Stream es: " + ms1.Capacity + " bytes"
        );

        Console.WriteLine(
            "La longitud del Stream es: " + ms1.Length + " bytes"
        );

        Console.WriteLine(
            "La posición del Stream es: " + ms1.Position + " bytes"
        );
    }
}