using System;

public class Circulo
{
    // Atributo privado que almacena el radio del círculo
    private double radio;

    // Constructor que inicializa el radio del círculo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Propiedad para acceder y modificar el radio
    public double Radio
    {
        get { return radio; }
        set { radio = value; }
    }

    // Método para calcular el área del círculo
    // Fórmula: π * radio^2
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Método para calcular el perímetro del círculo
    // Fórmula: 2 * π * radio
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}
