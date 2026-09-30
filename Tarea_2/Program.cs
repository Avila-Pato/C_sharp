class Program
{
    static void Main(string[] args)
    {

    }

    struct Cliente
    {
        string nombre;
        string apellido;
        string id;
        int edad;

        public global::System.String Nombre { get => nombre; set => nombre = value; }
        public global::System.String Apellido { get => apellido; set => apellido = value; }
        public global::System.String Id { get => id; set => id = value; }
        public global::System.Int32 Edad { get => edad; set => edad = value; }
    }

    enum Destinos
    {
        Guadalajara = 900,
        Monterrey = 1000,
        LosAngeles = 1700
    }
    enum Destinos
    {
        Siete_AM = 7,
        Tres_PM = 15,
        Ocho_PM = 20
    }

    enum SeccionAvion
    {
        Atras = 0,
        Centro = 50,
        Adelante = 80
    }

    enum TipoAsiento
    {
        Medio = 20,
        Pasillo = 60,
        Ventana = 90
    }
}