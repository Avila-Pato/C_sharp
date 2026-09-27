using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string nombreJugador1, nombreJugador2;
            int primerTurno;

            // Pedimos el nombre del jugador 1
            Console.Write("Jugador 1, escoge tu nombre: ");
            nombreJugador1 = Console.ReadLine();

            // Creamos jugador 1 y enviamos la salud inicial
            Jugador jugador1 = new Jugador(nombreJugador1, 1000);

            // Preguntamos personaje y arma
            jugador1.EscogerPersonaje();
            jugador1.EscogerArma();

            // Pedimos el nombre del jugador 2
            Console.Write("Jugador 2, escoge tu nombre: ");
            nombreJugador2 = Console.ReadLine();

            // Creamos al segundo jugador y enviamos su salud inicial
            Jugador jugador2 = new Jugador(nombreJugador2, 1000);

            // Preguntamos personaje y arma
            jugador2.EscogerPersonaje();
            jugador2.EscogerArma();

            // Invocamos TirarDados
            primerTurno = Batalla.TirarDados();

            // Determinamos cuál jugador empezará primero
            if (primerTurno == 1)
            {
                Console.WriteLine($"{jugador1.Nombre} empieza primero!\n");
                Batalla.SimularBatalla(jugador1, jugador2);
            }
            else
            {
                Console.WriteLine($"{jugador2.Nombre} empieza primero!\n");
                Batalla.SimularBatalla(jugador2, jugador1);
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

    enum TipoPersonaje
    {
        Escudero,
        Arquero,
        Caballero
    }

    enum TipoArma
    {
        Espada,
        Arco,
        Martillo
    }

    class Jugador
    {
        private string nombre;
        private int salud;
        private int ataque;
        private int defensa;
        private TipoPersonaje personajeEscogido;
        private TipoArma armaEquipada;

        Random random = new Random();

        // Encapsulamiento
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Salud { get { return salud; } set { salud = value; } }
        public int Ataque { get { return ataque; } set { ataque = value; } }
        public int Defensa { get { return defensa; } set { defensa = value; } }
        internal TipoPersonaje PersonajeEscogido { get { return personajeEscogido; } set { personajeEscogido = value; } }
        internal TipoArma ArmaEquipada { get { return armaEquipada; } set { armaEquipada = value; } }

        public Jugador(string nombrePa, int saludPa)
        {
            nombre = nombrePa;
            salud = saludPa;
        }

        public void EscogerPersonaje()
        {
            int option;
            Console.Clear();

            do
            {
                Console.WriteLine($"=== {nombre}, ESCOGE TU PERSONAJE ===");
                Console.WriteLine("1. Escudero");
                Console.WriteLine("2. Arquero");
                Console.WriteLine("3. Caballero");
                Console.Write("\nOpción: ");

                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    option = 0;
                }

                Console.Clear();

                switch (option)
                {
                    case 1:
                        personajeEscogido = TipoPersonaje.Escudero;
                        break;
                    case 2:
                        personajeEscogido = TipoPersonaje.Arquero;
                        break;
                    case 3:
                        personajeEscogido = TipoPersonaje.Caballero;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo.\n");
                        break;
                }

            } while (option < 1 || option > 3);

            ResumenPersonajeEscogido();
        }

        public void ResumenPersonajeEscogido()
        {
            Console.WriteLine($"{nombre}, ahora eres \"{PersonajeEscogido}\"");
            Console.Write("\nPresiona cualquier tecla para continuar....");
            Console.ReadKey();
            Console.Clear();
        }

        public void EscogerArma()
        {
            int opcion;
            Console.Clear();

            do
            {
                Console.WriteLine($"=== {nombre}, ESCOGE TU ARMA ===");
                Console.WriteLine("1. Espada (Ataque: 130, Defensa: 40)");
                Console.WriteLine("2. Arco (Ataque: 140, Defensa: 30)");
                Console.WriteLine("3. Martillo (Ataque: 150, Defensa: 20)");
                Console.Write("\nOpción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        ArmaEquipada = TipoArma.Espada;
                        ValoresAtaqueDefensaArma();
                        ResumenArmaEscogida();
                        break;
                    case 2:
                        ArmaEquipada = TipoArma.Arco;
                        ValoresAtaqueDefensaArma();
                        ResumenArmaEscogida();
                        break;
                    case 3:
                        ArmaEquipada = TipoArma.Martillo;
                        ValoresAtaqueDefensaArma();
                        ResumenArmaEscogida();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo.\n");
                        break;
                }

            } while (opcion < 1 || opcion > 3);
        }

        public void ValoresAtaqueDefensaArma()
        {
            switch (ArmaEquipada)
            {
                case TipoArma.Espada:
                    Ataque = 130;
                    Defensa = 40;
                    break;
                case TipoArma.Arco:
                    Ataque = 140;
                    Defensa = 30;
                    break;
                case TipoArma.Martillo:
                    Ataque = 150;
                    Defensa = 20;
                    break;
            }
        }

        public void ResumenArmaEscogida()
        {
            Console.WriteLine($"{Nombre}, escogiste \"{ArmaEquipada}\"\nCon un nivel de ataque de [{Ataque}] y una defensa de [{Defensa}]");
            Console.Write("\nPresiona cualquier tecla para continuar....");
            Console.ReadKey();
            Console.Clear();
        }

        public void Atacar()
        {
            Console.WriteLine($"¡{PersonajeEscogido} {Nombre} ataca con su {ArmaEquipada}!");
        }

        public void Defender()
        {
            Console.WriteLine($"¡{PersonajeEscogido} {Nombre} se defiende con su {ArmaEquipada}!");
        }

        public void EscogerAtacarDefender()
        {
            int opcion;

            do
            {
                Console.WriteLine("\n1. Atacar");
                Console.WriteLine("2. Defender");
                Console.Write($"\n[{PersonajeEscogido} {Nombre}], elige una acción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0;
                }

                switch (opcion)
                {
                    case 1:
                        Atacar();
                        break;
                    case 2:
                        Defender();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo.");
                        break;
                }

            } while (opcion < 1 || opcion > 2);
        }

        public void ResumenJugador()
        {
            Console.WriteLine($"[{PersonajeEscogido} {Nombre}] Salud: {Salud} | [{ArmaEquipada}] Ataque: {Ataque}, Defensa: {Defensa}");
        }

        public void CalcularDamage(int ataqueOtroJugadorPa)
        {
            int ataqueSorpresa = random.Next(-15, 16);
            int damageRecibido = ataqueOtroJugadorPa - Defensa + ataqueSorpresa;

            if (damageRecibido < 0) damageRecibido = 0; // Evita curar al jugador si la defensa es muy alta

            Salud -= damageRecibido;
            Console.WriteLine($"-> {Nombre} recibió {damageRecibido} de daño. Salud restante: {Salud}");
        }
    }

    class Batalla
    {
        static Random random = new Random();

        public static int TirarDados()
        {
            Console.Write("Presiona cualquier tecla para tirar los dados y determinar quién comienza....");
            Console.ReadKey();
            Console.Clear();

            int primerTurno = random.Next(1, 3);
            return primerTurno;
        }

        public static void SimularBatalla(Jugador jugador1Pa, Jugador jugador2Pa)
        {
            Console.WriteLine("=== LA BATALLA HA COMENZADO ===\n");

            for (int ronda = 1; ronda <= 4; ronda++)
            {
                Console.WriteLine($"\n--- RONDA {ronda} ---");
                jugador1Pa.ResumenJugador();
                jugador2Pa.ResumenJugador();

                // Turno Jugador 1
                jugador1Pa.EscogerAtacarDefender();
                jugador2Pa.CalcularDamage(jugador1Pa.Ataque);

                if (jugador2Pa.Salud <= 0) break;

                // Turno Jugador 2
                jugador2Pa.EscogerAtacarDefender();
                jugador1Pa.CalcularDamage(jugador2Pa.Ataque);

                if (jugador1Pa.Salud <= 0) break;
            }

            // Fin de la batalla
            Console.WriteLine("\n==============================");
            Console.WriteLine("      BATALLA TERMINADA       ");
            Console.WriteLine("==============================");
            jugador1Pa.ResumenJugador();
            jugador2Pa.ResumenJugador();

            // Determinamos el ganador
            if (jugador1Pa.Salud > jugador2Pa.Salud)
            {
                Console.WriteLine($"\n¡{jugador1Pa.Nombre} ha ganado la batalla!");
            }
            else if (jugador2Pa.Salud > jugador1Pa.Salud)
            {
                Console.WriteLine($"\n¡{jugador2Pa.Nombre} ha ganado la batalla!");
            }
            else
            {
                Console.WriteLine("\n¡Es un empate!");
            }
        }
    }
}