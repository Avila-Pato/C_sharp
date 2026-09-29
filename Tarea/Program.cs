using System;
using System.Collections.Generic;

namespace TareaInventario
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;

            int opcion;

            Inventario inventario = new Inventario();

            do
            {
                Console.Clear();

                Console.WriteLine("\nMundo Celular\n");
                Console.WriteLine("1. Agregar Producto");
                Console.WriteLine("2. Mostrar Inventario");
                Console.WriteLine("3. Eliminar Producto");
                Console.WriteLine("4. Salir");

                Console.Write("Ingrese una opcion");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        inventario.AgregarProducto();
                        break;
                    case 2:
                        inventario.MostrarProductos();
                        break;
                    case 3:
                        inventario.EliminarProducto();
                        break;
                    case 4:
                        repetir = false;
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta intente de neuvo");
                        break;
                }
            } while (repetir);
        }
    }

    struct Celular
    {
        string marca;
        string modelo;
        int memoriaPrincipal;
        double precio;
        int stock;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int MemoriaPrincipal { get => memoriaPrincipal; set => memoriaPrincipal = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }

    class Inventario
    {
        private List<Celular> listaCelulares = new List<Celular>();

        public void AgregarProducto()
        {
            Celular nuevoProducto = new Celular();

            Console.Clear();
            Console.WriteLine("\n\t\tAgregar producto\n");

            Console.Write("Marca: ");
            nuevoProducto.Marca = Console.ReadLine();

            Console.Write("Modelo: ");
            nuevoProducto.Modelo = Console.ReadLine();

            Console.Write("Memoria: ");
            nuevoProducto.MemoriaPrincipal = int.Parse(Console.ReadLine());

            Console.Write("Precio: $");
            nuevoProducto.Precio = double.Parse(Console.ReadLine());

            Console.Write("Stock: ");
            nuevoProducto.Stock = int.Parse(Console.ReadLine());

            listaCelulares.Add(nuevoProducto);

            Console.Write("Producto agregado. Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public void MostrarProductos()
        {
            Console.Clear();
            if (listaCelulares.Count == 0)
            {
                Console.WriteLine("¡El inventario está vacío!");
            }
            else
            {
                int indice = 1;
                Console.WriteLine("Inventario de productos:\n");

                foreach (var elemento in listaCelulares)
                {
                    Console.WriteLine($"{indice}. - Marca: {elemento.Marca}, Modelo: {elemento.Modelo}, " +
                        $"Memoria: {elemento.MemoriaPrincipal}, Precio: ${elemento.Precio}, Stock: {elemento.Stock}");
                    indice++;
                }
            }
            Console.Write("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public void EliminarProducto()
        {
            // Variable para indicar el indice del producto a eliminar
            int productoEliminar;

            Console.Clear();
            if (listaCelulares.Count == 0)
            {
                Console.WriteLine("El inventario esta vacio no hay nada que eliminar");
            }
            else
            {
                Console.Write($"Ingresa el numero del prucoto que desea eliminar del 1 al {listaCelulares.Count}: ");
                //DEcimos que es -1 para que el indice ingresado coincida con el indire real de la List
                productoEliminar = Convert.ToInt32(Console.ReadLine()) - 1;

                //Verificamos quie el numero ingresado sea valido

                if (productoEliminar >= 0 && productoEliminar < listaCelulares.Count)
                {
                    //Confirma si el Producto ingresado es el que desea eliminar
                    Console.Write($"El producto que deseas eliminar es: \"{listaCelulares[productoEliminar].Marca} {listaCelulares[productoEliminar].Modelo}\"" +
                        $"(Si/No): ");

                    string opcion = Console.ReadLine().ToLower();

                    if (opcion == "Si")
                    {
                        //Mostrar resumen de eliminado
                        string marcaEliminado = listaCelulares[productoEliminar].Marca;
                        string modeloEliminado = listaCelulares[productoEliminar].Modelo;

                        //Eliminaos el producto
                        listaCelulares.RemoveAt(productoEliminar);

                        // Le mostramos al usuario el libro que se elimino
                        Console.WriteLine($"\n El producto \" {marcaEliminado} {modeloEliminado}\" Fue Elimado Correctamente ");
                    }
                    else
                    {
                        Console.WriteLine("Operacion Cancelada");
                    }
                }
                else
                {
                    Console.WriteLine("El numero del Producto No es valido");
                }
            }
            Console.Write("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}