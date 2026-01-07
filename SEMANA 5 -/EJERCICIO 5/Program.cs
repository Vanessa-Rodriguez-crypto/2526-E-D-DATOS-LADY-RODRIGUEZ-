using System;

class Program
{
    static void Main()
    {
        Estadistica estadistica = new Estadistica();
        estadistica.LeerNumeros();

        Console.WriteLine($"Media: {estadistica.CalcularMedia()}");
        Console.WriteLine($"Desviación típica: {estadistica.CalcularDesviacionTipica()}");
    }
}
