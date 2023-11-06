using System;

public class Ejercicio18
{
    public static void HallarSumasYCantidades()
    {
        Console.WriteLine("Ingrese el tamaño del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        Console.WriteLine("Ingrese los elementos del vector A:");
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        int sumaPares = 0, sumaImpares = 0, sumaPrimos = 0;
        int cantPares = 0, cantImpares = 0, cantPrimos = 0;

        foreach (int numero in a)
        {
            if (numero % 2 == 0)
            {
                sumaPares += numero;
                cantPares++;
            }
            else
            {
                sumaImpares += numero;
                cantImpares++;
            }

            if (EsPrimo(numero))
            {
                sumaPrimos += numero;
                cantPrimos++;
            }
        }

        Console.WriteLine($"Suma de pares: {sumaPares}");
        Console.WriteLine($"Suma de impares: {sumaImpares}");
        Console.WriteLine($"Suma de primos: {sumaPrimos}");
        Console.WriteLine($"Cantidad de pares: {cantPares}");
        Console.WriteLine($"Cantidad de impares: {cantImpares}");
        Console.WriteLine($"Cantidad de primos: {cantPrimos}");
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
