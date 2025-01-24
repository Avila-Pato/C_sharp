namespace taskfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                byte i, alumnos;
                double calificacion, sumacalif = 0, promedio;

                Console.Write("Ingrese el número de alumnos: ");
                alumnos = Convert.ToByte(Console.ReadLine());

                for (i = 1; i <= alumnos; i++)
                {
                    Console.Write("Ingrese la calificación del alumno {0}: ", i);
                    calificacion = Convert.ToDouble(Console.ReadLine());
                    sumacalif += calificacion;
                }
                promedio = sumacalif / alumnos;

                Console.WriteLine("El promedio de calificaciones es: {0}", promedio);

            }
          }

        }