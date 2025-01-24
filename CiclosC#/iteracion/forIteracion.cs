namespace forIteracion
//Busqueda de un elemento en un arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int elementoBuscado = 5;
            bool encontrado = false;

            for(int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == elementoBuscado)
                {
                    encontrado = true;
                    break;
                }
            
            }
if(encontrado)
            {
                Console.WriteLine("El numero {buscar} se encuentra en el array");
            }
else
            {
                Console.WriteLine("El numero {buscar} no se encuentra en el array");
                Connsole.ReadKey();
            }
    }
}
