using System;

public class Ejercicio9
{
    public static void IntercalarElementos()
    {
        Console.WriteLine("Ingrese el tamaño del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        Console.WriteLine("Ingrese los elementos del vector A:");
        for (int v = 0; v < n; v++)
        {
            a[v] = int.Parse(Console.ReadLine());
        }

        for (int v = 1; v < n; v += 2)
        {
            int temp = a[v];
            a[v] = a[v - 1];
            a[v - 1] = temp;
        }

        Console.WriteLine("Vector con elementos intercalados:");
        for (int v = 0; v < n; v++)
        {
            Console.WriteLine(a[v]);
        }
    }
}
