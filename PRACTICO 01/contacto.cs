using System;

namespace AgendaTelefonica
{
    // Clase Contacto
    // Representa un registro dentro de la agenda telefónica
    public class Contacto
    {
        // Atributos (tipos de datos primitivos)
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public bool Activo { get; set; }

        // Constructor de la clase Contacto
        public Contacto(string nombre, string telefono, string correo, bool activo)
        {
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Activo = activo;
        }

        // Método que muestra la información del contacto
        public void MostrarContacto()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Nombre   : " + Nombre);
            Console.WriteLine("Teléfono : " + Telefono);
            Console.WriteLine("Correo   : " + Correo);
            Console.WriteLine("Estado   : " + (Activo ? "Activo" : "Inactivo"));
        }
    }
}