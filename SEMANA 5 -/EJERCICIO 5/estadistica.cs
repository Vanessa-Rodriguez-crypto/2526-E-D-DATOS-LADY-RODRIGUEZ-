using System;
using System.Collections.Generic;
using System.Linq;

class Estadistica
{
    public List<double> Numeros { get; set; }

    public Estadistica()
    {
        Numeros = new List<double>();
    }

    public void LeerNumeros()
    {
        Console.Write("Ingrese números separados por comas: ");
        string entrada = Console.ReadLine();

        foreach (string n in entrada.Split(','))
        {
            Numeros.Add(double.Parse(n));
        }
    }

    public double CalcularMedia()
    {
        return Numeros.Average();
    }

    public double CalcularDesviacionTipica()
    {
        double media = CalcularMedia();
        double suma = 0;

        foreach (double n in Numeros)
        {
            suma += Math.Pow(n - media, 2);
        }

        return Math.Sqrt(suma / Numeros.Count);
    }
}
