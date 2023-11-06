using System;
using System.Collections.Generic;

public class Ejercicio22
{
    public static void VectorSinRepetidos()
    {
        Console.WriteLine("Ingrese la cantidad de elementos del vector A:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        Console.WriteLine("Ingrese los elementos del vector A:");
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        HashSet<int> visto = new HashSet<int>();
        List<int> b = new List<int>();

        foreach (var valor in a)
        {
            if (visto.Add(valor))
            {
                b.Add(valor);
            }
        }

        Console.WriteLine("Vector B sin elementos repetidos:");
        foreach (var valor in b)
        {
            Console.WriteLine(valor);
        }
    }
}
