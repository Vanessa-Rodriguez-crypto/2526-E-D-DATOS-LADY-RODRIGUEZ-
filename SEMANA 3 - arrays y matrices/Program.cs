using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto Estudiante
        Estudiante est = new Estudiante();

        // Captura de datos del estudiante
        Console.Write("Ingrese ID: ");
        est.ID = int.Parse(Console.ReadLine());

        Console.Write("Ingrese nombres: ");
        est.Nombres = Console.ReadLine();

        Console.Write("Ingrese apellidos: ");
        est.Apellidos = Console.ReadLine();

        Console.Write("Ingrese dirección: ");
        est.Direccion = Console.ReadLine();

        // Registro de los teléfonos
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Ingrese teléfono {i + 1}: ");
            est.Telefonos[i] = Console.ReadLine();
        }

        // Mostrar los datos ingresados
        Console.WriteLine("\n--- Datos del Estudiante ---");
        Console.WriteLine($"ID: {est.ID}");
        Console.WriteLine($"Nombres: {est.Nombres}");
        Console.WriteLine($"Apellidos: {est.Apellidos}");
        Console.WriteLine($"Dirección: {est.Direccion}");

        Console.WriteLine("Teléfonos registrados:");
        foreach (string tel in est.Telefonos)
        {
            Console.WriteLine(tel);
        }
    }
}
