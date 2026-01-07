using System;
using System.Collections.Generic;

class Loteria
{
    public List<int> Numeros { get; set; }

    public Loteria()
    {
        Numeros = new List<int>();
    }

    public void PedirNumeros()
    {
        Console.WriteLine("Ingrese 6 números ganadores:");
        for (int i = 0; i < 6; i++)
        {
            Numeros.Add(int.Parse(Console.ReadLine()));
        }
    }

    public void OrdenarNumeros()
    {
        Numeros.Sort();
    }

    public void MostrarNumeros()
    {
        Console.WriteLine("Números ordenados:");
        foreach (int n in Numeros)
        {
            Console.WriteLine(n);
        }
    }
}
