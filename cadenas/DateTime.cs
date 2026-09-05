using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadenas
{
    public class Fechas
    {
        public static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            Console.WriteLine(fecha);
            DateTime fechaNacimiento = new DateTime(1990, 5, 15);
            Console.WriteLine(fechaNacimiento);
            DateTime FechaHora = new DateTime(1990, 5, 15, 10, 30, 0);
            Console.WriteLine(FechaHora);
        }
    }
}