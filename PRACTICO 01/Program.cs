using System;
using System.Collections.Generic;

namespace AgendaTelefonica
{
    class Program
    {
        // Estructura de datos: Lista (vector dinámico)
        static List<Contacto> agenda = new List<Contacto>();

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("AGENDA TELEFÓNICA");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Listar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarContacto();
                        break;
                    case 2:
                        ListarContactos();
                        break;
                    case 3:
                        BuscarContacto();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 4);
        }

        // Método para agregar un contacto a la agenda
        static void AgregarContacto()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();

            Console.Write("Correo: ");
            string correo = Console.ReadLine();

            Console.Write("¿Contacto activo? (true/false): ");
            bool activo = bool.Parse(Console.ReadLine());

            Contacto nuevoContacto = new Contacto(nombre, telefono, correo, activo);
            agenda.Add(nuevoContacto);

            Console.WriteLine("Contacto agregado correctamente.");
        }

        // Método para listar todos los contactos
        static void ListarContactos()
        {
            if (agenda.Count == 0)
            {
                Console.WriteLine("No existen contactos registrados.");
                return;
            }

            foreach (Contacto c in agenda)
            {
                c.MostrarContacto();
            }
        }

        // Método para buscar un contacto por nombre
        static void BuscarContacto()
        {
            Console.Write("Ingrese el nombre a buscar: ");
            string nombreBuscado = Console.ReadLine();
            bool encontrado = false;

            foreach (Contacto c in agenda)
            {
                if (c.Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    c.MostrarContacto();
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }
    }
}
