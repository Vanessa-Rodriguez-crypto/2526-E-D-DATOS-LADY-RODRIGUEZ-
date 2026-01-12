using System;

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();
        Random random = new Random();

        // Crear lista con 50 números aleatorios entre 1 y 999
        for (int i = 0; i < 50; i++)
        {
            lista.Agregar(random.Next(1, 1000));
        }

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        // EJERCICIO 1: Invertir lista
        lista.Invertir();
        Console.WriteLine("\nLista invertida:");
        lista.Mostrar();

        // EJERCICIO 2: Eliminar nodos fuera de un rango
        Console.Write("\nIngrese el valor mínimo del rango: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor máximo del rango: ");
        int max = int.Parse(Console.ReadLine());

        lista.EliminarFueraDeRango(min, max);

        Console.WriteLine("\nLista después de eliminar nodos fuera del rango:");
        lista.Mostrar();

        Console.ReadKey();
    }
}
