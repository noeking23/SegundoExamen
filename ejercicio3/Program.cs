using System;

public class Ejercicio3
{
    public static void SumarParesEImparesVector()
    {
        Console.WriteLine("Ingrese el tamaño del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int f = 0, g = 0;

        for (int s = 0; s < n; s++)
        {
            Console.WriteLine($"Ingrese el elemento {s+1} del vector:");
            a[s] = int.Parse(Console.ReadLine());

            if (a[s] % 2 == 0)
            {
                f += a[s];
            }
            else
            {
                g += a[s];
            }
        }

        Console.WriteLine($"La suma de los elementos pares del vector es: {f}");
        Console.WriteLine($"La suma de los elementos impares del vector es: {g}");
    }
}
