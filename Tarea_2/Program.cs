class Program
{
    static void Main(string[] args)
    {
        // Llamamos a la clase ComprarBoletos para iniciar el proceso de reservación
        ComprarBoletos comprarBoletos = new ComprarBoletos();

        // Iniciamos el proceso de reservación
        comprarBoletos.Reservacion();
    }

    struct Cliente
    {
        string nombre;
        string apellido;
        string id;
        int edad;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public int Edad
        {
            get => edad;
            set => edad = value;
        }
    }

    enum Destinos
    {
        Guadalajara = 900,
        Monterrey = 1000,
        LosAngeles = 1700
    }

    enum Horarios
    {
        Siete_AM = 7,
        Tres_PM = 15,
        Ocho_PM = 20
    }

    enum SeccionAvion
    {
        bussiness = 500,
        economy = 200,
        firstClass = 1000
    }

    enum TipoAsiento
    {
        Medio = 20,
        Pasillo = 60,
        Ventana = 90
    }

    class ComprarBoletos
    {
        Destinos destinosEscogidos;
        Horarios horariosEscogidos;
        SeccionAvion seccionEscogida;
        TipoAsiento tipoAsientoEscogido;

        int precioBase;
        int precioSeccion;
        int precioAsiento;
        int precioFinal;

        public void Reservacion()
        {
            Console.WriteLine("Bienvenido a la reservación de Vuelos");

            // Creamos un objeto cliente
            Cliente cliente = new Cliente();

            Console.WriteLine("Ingrese la información que se le pide a continuación:");

            Console.Write("Nombre: ");
            cliente.Nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            cliente.Apellido = Console.ReadLine();

            Console.Write("Edad: ");
            cliente.Edad = int.Parse(Console.ReadLine());

            Console.Write("ID: ");
            cliente.Id = Console.ReadLine();

            // Seleccionamos las opciones de la reservación
            SeleccionarDestino();
            SeleccionarHorario();
            SeleccionarSeccion();

            // Mostramos el resumen
            ResumenReservacion(cliente);
        }

        public void SeleccionarDestino()
        {
            int opcionDestino;
            int indice = 1;

            Console.WriteLine("\nSeleccione el destino al que desea viajar:");

            foreach (Destinos elemento in Enum.GetValues(typeof(Destinos)))
            {
                Console.WriteLine($"{indice}. {elemento} - ${((int)elemento)}");
                indice++;
            }

            Console.Write("Ingrese el número del destino: ");
            opcionDestino = int.Parse(Console.ReadLine());

            switch (opcionDestino)
            {
                case 1:
                    destinosEscogidos = Destinos.Guadalajara;
                    precioBase = (int)destinosEscogidos;
                    break;

                case 2:
                    destinosEscogidos = Destinos.Monterrey;
                    precioBase = (int)destinosEscogidos;
                    break;

                case 3:
                    destinosEscogidos = Destinos.LosAngeles;
                    precioBase = (int)destinosEscogidos;
                    break;

                default:
                    Console.WriteLine("Opción inválida. Seleccionando destino por defecto: Guadalajara.");
                    destinosEscogidos = Destinos.Guadalajara;
                    precioBase = (int)destinosEscogidos;
                    break;
            }
        }

        public void SeleccionarHorario()
        {
            int opcionHorario;
            int indice = 1;

            Console.WriteLine("\nSeleccione el horario de salida:");

            foreach (Horarios elemento in Enum.GetValues(typeof(Horarios)))
            {
                Console.WriteLine($"{indice}. {elemento} - {((int)elemento)}:00");
                indice++;
            }

            Console.Write("Ingrese el número del horario: ");
            opcionHorario = int.Parse(Console.ReadLine());

            switch (opcionHorario)
            {
                case 1:
                    horariosEscogidos = Horarios.Siete_AM;
                    break;

                case 2:
                    horariosEscogidos = Horarios.Tres_PM;
                    break;

                case 3:
                    horariosEscogidos = Horarios.Ocho_PM;
                    break;

                default:
                    Console.WriteLine("Opción inválida. Seleccionando horario por defecto: 7 AM.");
                    horariosEscogidos = Horarios.Siete_AM;
                    break;
            }
        }

        public void SeleccionarSeccion()
        {
            int opcionSeccion;
            int indice = 1;

            Console.WriteLine("\nSeleccione la sección del avión:");

            foreach (SeccionAvion elemento in Enum.GetValues(typeof(SeccionAvion)))
            {
                Console.WriteLine($"{indice}. {elemento} - ${((int)elemento)}");
                indice++;
            }

            Console.Write("Ingrese el número de la sección: ");
            opcionSeccion = int.Parse(Console.ReadLine());

            switch (opcionSeccion)
            {
                case 1:
                    seccionEscogida = SeccionAvion.bussiness;
                    precioSeccion = (int)seccionEscogida;
                    break;

                case 2:
                    seccionEscogida = SeccionAvion.economy;
                    precioSeccion = (int)seccionEscogida;
                    break;

                case 3:
                    seccionEscogida = SeccionAvion.firstClass;
                    precioSeccion = (int)seccionEscogida;
                    break;

                default:
                    Console.WriteLine("Opción inválida. Seleccionando sección por defecto: Economy.");
                    seccionEscogida = SeccionAvion.economy;
                    precioSeccion = (int)seccionEscogida;
                    break;
            }
        }

        public void ResumenReservacion(Cliente cliente)
        {
            Console.Clear();

            precioFinal = precioBase + precioSeccion + precioAsiento;

            Console.WriteLine($"Nombre del cliente: {cliente.Nombre} {cliente.Apellido}");

            Console.WriteLine("\nResumen de la reservación:");
            Console.WriteLine($"Destino: {destinosEscogidos} - ${precioBase}");
            Console.WriteLine($"Horario: {horariosEscogidos}");
            Console.WriteLine($"Sección: {seccionEscogida} - ${precioSeccion}");
            Console.WriteLine($"Precio final: ${precioFinal}");

            Console.WriteLine("\nGracias por su reservación. ¡Buen viaje!");

            Console.ReadKey();
        }
    }
}