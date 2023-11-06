using System;

public class Ejercicio2
{
    public static void SumarElementosVector()
    {
        Console.WriteLine("Ingrese el tamaño del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int d = 0;

        for (int s = 0; s < n; s++)
        {
            Console.WriteLine($"Ingrese el elemento {s+1} del vector:");
            a[s] = int.Parse(Console.ReadLine());
            d += a[s];
        }

        Console.WriteLine($"La suma de los elementos del vector es: {d}");
    }
}
    