using System;

public class Cuadrado
{
    // Atributo privado para el lado del cuadrado
    private double lado;

    // Constructor que inicializa el lado
    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    // Propiedad para acceder o modificar el lado
    public double Lado
    {
        get { return lado; }
        set { lado = value; }
    }

    // Método para calcular el área
    // Fórmula: lado^2
    public double CalcularArea()
    {
        return lado * lado;
    }

    // Método para calcular el perímetro
    // Fórmula: 4 * lado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}
