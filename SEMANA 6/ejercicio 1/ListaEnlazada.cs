using System;

public class ListaEnlazada
{
    private Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    // Agregar nodo al final
    public void Agregar(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Mostrar lista
    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    // EJERCICIO 1: Invertir lista enlazada
    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }
        cabeza = anterior;
    }

    // EJERCICIO 2: Eliminar nodos fuera de un rango
    public void EliminarFueraDeRango(int minimo, int maximo)
    {
        while (cabeza != null && (cabeza.Dato < minimo || cabeza.Dato > maximo))
        {
            cabeza = cabeza.Siguiente;
        }

        Nodo actual = cabeza;

        while (actual != null && actual.Siguiente != null)
        {
            if (actual.Siguiente.Dato < minimo || actual.Siguiente.Dato > maximo)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
            else
            {
                actual = actual.Siguiente;
            }
        }
    }
}
