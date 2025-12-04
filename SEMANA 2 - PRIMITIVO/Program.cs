using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Cálculo de Figuras Geométricas ===");

        // =====================
        //        CÍRCULO
        // =====================
        Circulo c = new Circulo(5); // Radio = 5
        Console.WriteLine("\n--- CÍRCULO ---");
        Console.WriteLine($"Radio: {c.Radio}");
        Console.WriteLine($"Área: {c.CalcularArea()}");
        Console.WriteLine($"Perímetro: {c.CalcularPerimetro()}");

        // =====================
        //      RECTÁNGULO
        // =====================
        Rectangulo r = new Rectangulo(4, 6); // Largo = 4, Ancho = 6
        Console.WriteLine("\n--- RECTÁNGULO ---");
        Console.WriteLine($"Largo: {r.Largo}");
        Console.WriteLine($"Ancho: {r.Ancho}");
        Console.WriteLine($"Área: {r.CalcularArea()}");
        Console.WriteLine($"Perímetro: {r.CalcularPerimetro()}");

        // =====================
        //       CUADRADO
        // =====================
        Cuadrado q = new Cuadrado(7); // Lado = 7
        Console.WriteLine("\n--- CUADRADO ---");
        Console.WriteLine($"Lado: {q.Lado}");
        Console.WriteLine($"Área: {q.CalcularArea()}");
        Console.WriteLine($"Perímetro: {q.CalcularPerimetro()}");

        Console.WriteLine("\nEjecución finalizada. Presiona ENTER para salir.");
        Console.ReadLine();
    }
}
