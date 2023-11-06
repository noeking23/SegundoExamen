using System;

public class Ejercicio28
{
    public static void ContarPrimos()
    {
        Console.WriteLine("Ingrese la cantidad de elementos del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] vector = new int[n];

        Console.WriteLine("Ingrese los elementos del vector:");
        for (int i = 0; i < n; i++)
        {
            vector[i] = int.Parse(Console.ReadLine());
        }

        int contadorPrimos = 0;
        foreach (var valor in vector)
        {
            if (EsPrimo(valor))
            {
                contadorPrimos++;
            }
        }

        Console.WriteLine($"Cantidad de números primos: {contadorPrimos}");
        Console.WriteLine($"Cantidad de números no primos: {n - contadorPrimos}");
    }

    private static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;

        var limite = (int)Math.Sqrt(numero);
        for (int i = 3; i <= limite; i += 2)
        {
            if (numero % i == 0) return false;
        }

        return true;
    }
}
