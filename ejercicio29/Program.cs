using System;
using System.Collections.Generic;

public class Ejercicio29
{
    public static void GenerarPrimos(int n)
    {
        List<int> primos = new List<int>();
        int numero = 2;

        while (primos.Count < n)
        {
            if (EsPrimo(numero))
            {
                primos.Add(numero);
            }
            numero++;
        }

        Console.WriteLine("Vector P de números primos:");
        foreach (int primo in primos)
        {
            Console.Write(primo + " ");
        }
    }

    private static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;

        int raiz = (int)Math.Sqrt(numero);
        for (int i = 3; i <= raiz; i += 2)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
}
