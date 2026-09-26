using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadenas
{
    public class GeneradorContra
    {
        public static void Main(string[] args)
        {


            // varaibles para pedir usuario
            string nombreUsuario, contraseña;
            // \t => tabulador, \n => salto de linea
            // \n => salto de linea
            Console.WriteLine("\t\tRegistro de usuario\n\n");

            //Pedimos el nombre del usuario
            Console.Write("Ingrese su nombre de usuario: ");
            nombreUsuario = Console.ReadLine() ?? "";

            // Preguntamos si desea generar una contraseña aleatoria o crearla manualmente
            Console.WriteLine("\nDesea generar una contraseña aleatoria o crearla manualmente?");
            Console.WriteLine("1. Generar contraseña aleatoria");
            Console.WriteLine("2. Crear contraseña manualmente");

            var flag = true;
            while (flag)
            {
                Console.Write("Ingrese una opción: ");
                var opcion = Console.ReadLine() ?? "";
                opcion = opcion.Trim().ToLower(); // Eliminamos espacios en blanco al inicio y al final de la cadena

                switch (opcion)
                {
                    case "1":
                        ContraseñaGenerator generador = new ContraseñaGenerator();
                        contraseña = generador.Generar();

                        Console.WriteLine($"\nSu contraseña generada es: {contraseña}");

                        flag = false;
                        break;

                    case "2":
                        Console.Write("\nIngrese su contraseña: ");
                        contraseña = Console.ReadLine() ?? "";

                        Console.WriteLine($"\nSu contraseña ingresada es: {contraseña}");

                        flag = false;
                        break;

                    default:
                        Console.WriteLine("\nOpción inválida. Por favor, ingrese 1 o 2.");
                        break;
                }
            }

        }
    }

    class ContraseñaGenerator

    {
        string numeros = "0123456789";
        string letrasMayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
        string simbolos = "!@#$%&*()_+-=";

        // Contadores para verificar el numero de caracteres de cada tipo
        int contadorNumeros = 0;
        int contadorLetrasMayusculas = 0;
        int contadorLetrasMinusculas = 0;
        int contadorSimbolos = 0;

        // Instanciamos un objeto Random para generar numeros aleatorios
        Random random = new Random();

        //Variables que van a determinar el numero de caracteres que usara cada grupo de caracteres
        double porcentajeNumeros = 0.2; // 20% de numeros
        double porcentajeLetrasMayusculas = 0.2; // 20% de letras mayusculas
        double porcentajeLetrasMinusculas = 0.4; // 40% de letras minusculas
        double porcentajeSimbolos = 0.2; // 20% de simbolos

        // Metodo para generar una contraseña aleatoria
        public string Generar()
        {
            // Guardamos la contra
            string contraseñaGenerada = "";

            // declaramos una variable que guarda el tamaño de la contraseña, generamos un numero aleatorio entre 8 y 16
            //Next es para generar numeros aleatorios dentro de un rango, en este caso entre 8 y 16
            int longitudContrasena = random.Next(8, 17);

            // cantidad objetivo de caracteres para cada grupo, en base al porcentaje y la longitud total
            int metaNumeros = (int)Math.Ceiling(longitudContrasena * porcentajeNumeros);
            int metaLetrasMayusculas = (int)Math.Ceiling(longitudContrasena * porcentajeLetrasMayusculas);
            int metaLetrasMinusculas = (int)Math.Ceiling(longitudContrasena * porcentajeLetrasMinusculas);
            int metaSimbolos = (int)Math.Ceiling(longitudContrasena * porcentajeSimbolos);

            // almacena a cada 1 de los caracteres que se van a escoger de cada grupo de caracteres
            char caracterEscogido;

            // usamos una iteracion while para ir colocando un caracter (de los 4 grupos)
            // hasta que completemos la longitud de la contraseña deseada
            while (contraseñaGenerada.Length < longitudContrasena)
            {
                switch (random.Next(0, 4))
                {
                    case 0:
                        // Si los caracteres numericos que contiene la contra son menores a los que se debe contener,
                        // entonces ingresa al bloque de codigo y los genera
                        if (contadorNumeros < metaNumeros)
                        {
                            // caracterEscogido se le va a asignar un caracter aleatorio de los contenidos en el string numeros,
                            // basandose en el indice y apoyandose de la propiedad Length
                            caracterEscogido = numeros[random.Next(0, numeros.Length)];
                            contraseñaGenerada += caracterEscogido; // concatenamos el caracter escogido a la contraseña generada
                            contadorNumeros++; // incrementamos el contador de caracteres numericos
                        }
                        break;
                    case 1:
                        // Si los caracteres de letras mayusculas que contiene la contra son menores a los que se debe contener,
                        // entonces ingresa al bloque de codigo y los genera
                        if (contadorLetrasMayusculas < metaLetrasMayusculas)
                        {
                            // caracterEscogido se le va a asignar un caracter aleatorio de los contenidos en el string letrasMayusculas,
                            // basandose en el indice y apoyandose de la propiedad Length
                            caracterEscogido = letrasMayusculas[random.Next(0, letrasMayusculas.Length)];
                            contraseñaGenerada += caracterEscogido; // concatenamos el caracter escogido a la contraseña generada
                            contadorLetrasMayusculas++; // incrementamos el contador de caracteres de letras mayusculas
                        }
                        break;
                    case 2:
                        // Si los caracteres de letras minusculas que contiene la contra son menores a los que se debe contener,
                        // entonces ingresa al bloque de codigo y los genera
                        if (contadorLetrasMinusculas < metaLetrasMinusculas)
                        {
                            // caracterEscogido se le va a asignar un caracter aleatorio de los contenidos en el string letrasMinusculas,
                            // basandose en el indice y apoyandose de la propiedad Length
                            caracterEscogido = letrasMinusculas[random.Next(0, letrasMinusculas.Length)];
                            contraseñaGenerada += caracterEscogido; // concatenamos el caracter escogido a la contraseña generada
                            contadorLetrasMinusculas++; // incrementamos el contador de caracteres de letras minusculas
                        }
                        break;
                    case 3:
                        // Si los caracteres especiales que contiene la contra son menores a los que se debe contener,
                        // entonces ingresa al bloque de codigo y los genera
                        if (contadorSimbolos < metaSimbolos)
                        {
                            // caracterEscogido se le va a asignar un caracter aleatorio de los contenidos en el string simbolos,
                            // basandose en el indice y apoyandose de la propiedad Length
                            caracterEscogido = simbolos[random.Next(0, simbolos.Length)];
                            contraseñaGenerada += caracterEscogido; // concatenamos el caracter escogido a la contraseña generada
                            contadorSimbolos++; // incrementamos el contador de caracteres especiales
                        }
                        break;
                }
            }

            return contraseñaGenerada;
        }
    }
}

class ComprobarContraseña
{
    string contraseñaPa;

    public ComprobarContraseña(string contraseñaPa)
    {
        this.contraseñaPa = contraseñaPa;
    }

    // Metodo que valida la contraseña y devuelve si es valida o no,
    // ademas deja el motivo del error en mensajeError cuando no es valida
    public bool Validar(out string mensajeError)
    {
        bool contraseñaValida = false;
        //Variables para cada criterio de la contraseña
        bool hayNumeros = false;
        bool hayLetrasMayusculas = false;
        bool hayLetrasMinusculas = false;
        bool haySimbolos = false;

        // Varaible para contener el mensaje de error
        mensajeError = "";

        // verificar primero se cumpla la longitud de la contraseña
        if (contraseñaPa.Length >= 8 && contraseñaPa.Length <= 16)
        {
            // recorremos cada caracter de la contraseña para saber que tipos contiene
            foreach (char caracter in contraseñaPa)
            {
                if (char.IsDigit(caracter))
                    hayNumeros = true;
                else if (char.IsUpper(caracter))
                    hayLetrasMayusculas = true;
                else if (char.IsLower(caracter))
                    hayLetrasMinusculas = true;
                else
                    haySimbolos = true;
            }

            if (hayNumeros && hayLetrasMayusculas && hayLetrasMinusculas && haySimbolos)
            {
                contraseñaValida = true;
            }
            else
            {
                mensajeError = "La contraseña debe contener numeros, letras mayusculas, letras minusculas y simbolos.";
            }
        }
        else
        {
            mensajeError = "La contraseña debe tener entre 8 y 16 caracteres.";
        }

        return contraseñaValida;
    }
}

