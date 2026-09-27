


static void Main(string[] args)
{
    // Variable tipo del enum
    Semana diaPago = Semana.Viernes
    Console.WriteLine((int)diaPago)
    string quintoDiaSemana = diaPago.ToString();

    // GetNames
    // Obtiene los nombres de todos los valores del enum.

    // GetValues
    // Obtiene todos los valores definidos dentro del enum.

    // Parse
    // Convierte un texto en un valor del enum.

    // IsDefined
    // Comprueba si un valor existe dentro del enum.



}

enum Semana
{
    Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo
}

enum BonosSueldosJefes : uint
{
    PrimerNivel,
    SegundoNivel = 4_000_000_000
    //Sepradores noa efta la logica
    TercelNivel = 2_000_000_000
}

enum BonosSueldosJefes : long
{
    PrimerNivel,
    SegundoNivel = 6_000_000_000
    //Sepradores noa efta la logica
    TercelNivel = 2_000_000_000
}

enum BonosSueldosJefes : byte
{
    PrimerNivel = 200
    SegundoNivel = 250
    //Sepradores noa efta la logica
    TercelNivel = 100
}