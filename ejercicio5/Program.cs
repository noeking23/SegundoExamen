using System;

public class Ejercicio5
{
    public static void MostrarMaximoYMinimo()
    {
        Console.WriteLine("Ingrese el tamaño del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int k = int.MinValue, l = int.MaxValue;
        int m = 0, b = 0;

        for (int s = 0; s < n; s++)
        {
            Console.WriteLine($"Ingrese el elemento {s+1} del vector:");
            a[s] = int.Parse(Console.ReadLine());

            if (a[s] > k)
            {
                k = a[s];
                m = s;
            }

            if (a[s] < l)
            {
                l = a[s];
                b = s;
            }
        }

        Console.WriteLine($"El máximo elemento es {k} y está en la posición {m + 1}");
        Console.WriteLine($"El mínimo elemento es {l} y está en la posición {b + 1}");
    }
}
