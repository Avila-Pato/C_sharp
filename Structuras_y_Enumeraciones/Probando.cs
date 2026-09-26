using System.ComponentModel.Design;

namespace Structuras_y_Enumeraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            bool repetir = true;
            string option;

            // Creamos una instancia de la clase biblioteca
            Biblioteca biblioteca1 = new Biblioteca();

            // Menu
            do
            {
                Console.WriteLine("\nBiblioteca\n");
                Console.WriteLine("1. Agregar Libros");
                Console.WriteLine("2. Mostrar todos los libros");
                Console.WriteLine("3. Buscar libro");
                Console.WriteLine("4. Eliminar Libro");
                Console.WriteLine("5. Salir");

                Console.Write("Ingresa la opcion: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        biblioteca1.Agregarlibros();
                        break;

                    case "2":
                        biblioteca1.MostarLibros();
                        break;

                    case "3":
                        biblioteca1.BuscarLbro();
                        break;

                    case "4":
                        biblioteca1.EliminarLibro();
                        break;

                    case "5":
                        repetir = false;
                        break;

                    default:
                        Console.WriteLine("Operacion Invalida");
                        break;
                }

            } while (repetir);


            // ENUMERACIÓN
            // Sirve para definir un conjunto de valores posibles.
            // Dia dia = Dia.Domingo;

            //// ESTRUCTURA
            //// Sirve para agrupar datos relacionados.
            // Persona persona = new Persona
            //{
            //    Nombre = "Patricio",
            //    Edad = 27
            //};

            //Console.WriteLine($"Nombre: {persona.Nombre}");
            //Console.WriteLine($"Edad: {persona.Edad}");
            //Console.WriteLine($"Día: {dia}");

            //Console.ReadLine();
        }
    }

    // ENUM
    enum Dia
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }

    // STRUCT
    struct Persona
    {
        public string Nombre;
        public int Edad;
    }
}

// ejercicio la biblioteca
class Biblioteca
{
    // campos
    Libro[] libros;// matriz
    int cantidadLibros = 0;
    string buscarLibro;
    bool libroEncontrado;
    int posisionLibroEliminar;



    //Constructor
    public Biblioteca()
    {
        libros = new Libro[1000]; // Iniciar Matriz con una capcidad de mil elementos
    }

    //Funciones

    public void Agregarlibros()
    {
        if (cantidadLibros < libros.Length)
        {
            Console.Clear();
            Console.WriteLine($"Ingresar informacion para el libro {cantidadLibros + 1} \n");

            //Indice

            Console.Write("Ingresa el nombre del libro: ");
            libros[cantidadLibros].Titulo = Console.ReadLine();

            Console.Write("Ingresar el Autor: ");
            libros[cantidadLibros].Autor = Console.ReadLine();

            Console.Write("Ingresar el year: ");
            libros[cantidadLibros].Year = Console.ReadLine();

            cantidadLibros++;  // Aumentamos la cantidad de libros

            Console.Clear();
            Console.WriteLine("Listo agregados Correctamente");

        }
        else
        {
            Console.WriteLine("!Biblioteca llena, Intenta eliminar un libro");
        }

    }

    public void MostarLibros()
    {
        Console.Clear();

        if (cantidadLibros <= 0)
        {
            Console.WriteLine("Biblioteca vacia! Agrega libros para poder visualizarlos");
        }
        else
        {
            Console.WriteLine($"La cantidad de libros que hay es de {cantidadLibros}");

            for (int i = 0; i < cantidadLibros; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {libros[i].Titulo} - {libros[i].Autor} - {libros[i].Year}"
                );
            }
        }

        Console.Write("\nPresione cualquier tecla para continuar....");
        Console.ReadKey();
    }

    public void BuscarLbro()
    {
        Console.Clear();

        Console.Write("Ingresa el nombre del libro a buscar: ");
        buscarLibro = Console.ReadLine().ToLower();

        libroEncontrado = false; // campo en false para indicar que al iniciar recorrido
                                 // por la matriz no hemos encontrado un libro

        for (int i = 0; i < cantidadLibros; i++)
        {
            if (libros[i].Titulo.ToLower().Equals(buscarLibro))
            {
                Console.WriteLine(
                    $"El libro \"{libros[i].Titulo}\" del autor(a): \"{libros[i].Autor}\" " +
                    $"se encuentra disponible en la biblioteca en el indice: {i + 1}"
                );

                libroEncontrado = true; // evitar entrar en la secuencia if si es encontrado
                break;
            }
        }

        if (!libroEncontrado)
        {
            Console.WriteLine($"Libro no encontrado, intenta otro: {buscarLibro}");
        }

        Console.Write("\nPresione cualquier tecla para continuar....");
        Console.ReadKey();
    }

    public void EliminarLibro()
    {
        Console.Clear();

        if (cantidadLibros == 0)
        {
            Console.WriteLine("La biblioteca esta vacia no hay nada que eliminar");
        }
        else
        {
            Console.Write($"Ingresa el numero de libro que desea eliminar (1 al {cantidadLibros}): ");
            posisionLibroEliminar = Convert.ToInt32(Console.ReadLine()) - 1;

            // Decimos -1 para que el indice ingresado por el usuario coincida con el indice real
            // de la matriz

            // Verificacion que el numero ingresado sea valido
            if (posisionLibroEliminar >= 0 && posisionLibroEliminar < cantidadLibros)
            {
                // Confirmamos si el libro que ingreso es el que quiere eliminar
                Console.Write(
                    $"El libro que desea eliminar es: \"{libros[posisionLibroEliminar].Titulo}\" " +
                    "(Si/No): "
                );

                string option = Console.ReadLine().ToLower();

                if (option == "si")
                {
                    // Variables para mostrar un mensaje de cual fue el libro eliminado
                    string tituloEliminado = libros[posisionLibroEliminar].Titulo;
                    string autorEliminado = libros[posisionLibroEliminar].Autor;

                    for (int i = posisionLibroEliminar; i < cantidadLibros - 1; i++)
                    {
                        libros[i] = libros[i + 1];
                    }

                    cantidadLibros--; // reducimos la cantidad de libros a eliminar

                    Console.WriteLine(
                        $"El libro \"{tituloEliminado}\" del autor \"{autorEliminado}\" fue eliminado correctamente."
                    );
                }
                else
                {
                    Console.WriteLine("Operacion Cancelada");
                }
            }
            else
            {
                Console.WriteLine("Numero de libro invalido");
            }
        }

        Console.Write("\nPresione cualquier tecla para continuar....");
        Console.ReadKey();
    }

    struct Libro
    {
        // Campos
        string titulo;
        string autor;
        string year;

        // Propiedades
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Year { get => year; set => year = value; }

    }
}