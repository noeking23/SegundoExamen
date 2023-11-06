using System;

public class Ejercicio11
{
    public static void CombinarVectoresOrdenados()
    {
        Console.WriteLine("Ingrese el tamaño de los vectores:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] b = new int[n];
        int[] c = new int[2 * n];

        Console.WriteLine("Ingrese los elementos del vector A ya ordenados:");
        for (int v = 0; v < n; v++)
        {
            a[v] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ingrese los elementos del vector B ya ordenados:");
        for (int v = 0; v < n; v++)
        {
            b[v] = int.Parse(Console.ReadLine());
        }

        int i = 0, j = 0, k = 0;
        while (i < n && j < n)
        {
            if (a[i] < b[j])
            {
                c[k++] = a[i++];
            }
            else
            {
                c[k++] = b[j++];
            }
        }

        while (i < n)
        {
            c[k++] = a[i++];
        }

        while (j < n)
        {
            c[k++] = b[j++];
        }

        Console.WriteLine("Vector C ordenado combinado:");
        for (int v = 0; v < 2 * n; v++)
        {
            Console.WriteLine(c[v]);
        }
    }
}
