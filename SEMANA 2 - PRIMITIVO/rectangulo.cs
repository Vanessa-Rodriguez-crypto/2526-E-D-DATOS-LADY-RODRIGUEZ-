using System;

public class Rectangulo
{
    // Atributos privados del rectángulo
    private double largo;
    private double ancho;

    // Constructor para inicializar el rectángulo
    public Rectangulo(double largo, double ancho)
    {
        this.largo = largo;
        this.ancho = ancho;
    }

    // Propiedades para acceder a los atributos
    public double Largo
    {
        get { return largo; }
        set { largo = value; }
    }

    public double Ancho
    {
        get { return ancho; }
        set { ancho = value; }
    }

    // Método para calcular el área del rectángulo
    // Fórmula: largo * ancho
    public double CalcularArea()
    {
        return largo * ancho;
    }

    // Método para calcular el perímetro
    // Fórmula: 2 * (largo + ancho)
    public double CalcularPerimetro()
    {
        return 2 * (largo + ancho);
    }
}
