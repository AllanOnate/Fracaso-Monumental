using System;

class Invertirnumeros
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        string input = Console.ReadLine();

        if (IsNumeric(input))
        {
            string valorInverso = InvertirNumero(input);
            Console.WriteLine("La cifra ingresada de forma invertida es: " + valorInverso);
        }
        else
        {
            Console.WriteLine("El valor ingresado no es un número válido.");
        }
    }

    static bool IsNumeric(string input)
    {
        return int.TryParse(input, out _);
    }

    static string InvertirNumero(string numero)
    {
        char[] charArray = numero.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}