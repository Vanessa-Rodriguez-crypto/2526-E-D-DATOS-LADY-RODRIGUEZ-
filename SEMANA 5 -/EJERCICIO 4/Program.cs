using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        Palindromo p = new Palindromo();

        if (p.EsPalindromo(palabra))
            Console.WriteLine("La palabra es un palíndromo.");
        else
            Console.WriteLine("La palabra NO es un palíndromo.");
    }
}
