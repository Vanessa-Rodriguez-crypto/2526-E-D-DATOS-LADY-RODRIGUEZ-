using System;

class Palindromo
{
    public bool EsPalindromo(string palabra)
    {
        palabra = palabra.ToLower();
        char[] letras = palabra.ToCharArray();
        Array.Reverse(letras);
        string invertida = new string(letras);

        return palabra == invertida;
    }
}
