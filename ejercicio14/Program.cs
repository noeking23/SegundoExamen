using System;

public class Ejercicio14
{
    public static void InvertirVector()
    {
        Console.WriteLine("Ingrese el tamaño del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] b = new int[n];

        Console.WriteLine("Ingrese los elementos del vector A:");
        for (int v = 0; v < n; v++)
        {
            a[v] = int.Parse(Console.ReadLine());
        }

        for (int v = 0; v < n; v++)
        {
            b[n - v - 1] = a[v];
        }

        Console.WriteLine("Vector B invertido:");
        foreach (int valor in b)
        {
            Console.WriteLine(valor);
        }
    }
}
