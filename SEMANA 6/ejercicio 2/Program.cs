using System;

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();
        Random random = new Random();

        // Crear lista con 50 números aleatorios
        for (int i = 0; i < 50; i++)
        {
            lista.Agregar(random.Next(1, 1000));
        }

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        // Leer rango desde teclado
        Console.Write("\nIngrese el valor mínimo del rango: ");
        int minimo = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor máximo del rango: ");
        int maximo = int.Parse(Console.ReadLine());

        // Eliminar nodos fuera del rango
        lista.EliminarFueraDeRango(minimo, maximo);

        Console.WriteLine("\nLista después de eliminar nodos fuera del rango:");
        lista.Mostrar();

        Console.ReadKey();
    }
}
