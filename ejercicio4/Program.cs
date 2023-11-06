using System;

public class Ejercicio4
{
    public static void SumarElementosPosicionesParesEImpares()
    {
        Console.WriteLine("Ingrese el tamaño del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int h = 0, j = 0;

        for (int s = 0; s < n; s++)
        {
            Console.WriteLine($"Ingrese el elemento {s+1} del vector:");
            a[s] = int.Parse(Console.ReadLine());

            if ((s + 1) % 2 == 0)
            {
                h += a[s];
            }
            else
            {
                j += a[s];
            }
        }

        Console.WriteLine($"La suma de los elementos en posiciones pares es: {h}");
        Console.WriteLine($"La suma de los elementos en posiciones impares es: {j}");
    }
}
