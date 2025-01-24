namespace iteracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double  calif1, calif2, calif3, promedio;   

            Console.Write("Ingresa la calificación 1: ");
            calif1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la calificación 2: ");
            calif2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la calificación 3: ");
            calif3 = Convert.ToDouble(Console.ReadLine());

            promedio = (calif1 + calif2 + calif3) / 3;

            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();
        }
    }
}
