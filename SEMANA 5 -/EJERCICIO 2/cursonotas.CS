using System;
using System.Collections.Generic;
using System.Linq;

class CursoNotas
{
    public Dictionary<string, double> Notas { get; set; }

    public CursoNotas()
    {
        Notas = new Dictionary<string, double>
        {
            { "Matemáticas", 0 },
            { "Física", 0 },
            { "Química", 0 },
            { "Historia", 0 },
            { "Lengua", 0 }
        };
    }

    public void PedirNotas()
    {
        foreach (var asignatura in Notas.Keys.ToList())
        {
            Console.Write($"Ingrese la nota de {asignatura}: ");
            Notas[asignatura] = Convert.ToDouble(Console.ReadLine());
        }
    }

    public void MostrarNotas()
    {
        foreach (var nota in Notas)
        {
            Console.WriteLine($"En {nota.Key} has sacado {nota.Value}");
        }
    }
}
