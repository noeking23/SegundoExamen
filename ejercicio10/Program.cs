using System;

public class Ejercicio10
{
    public static void OrdenarVectorAscendente()
    {
        Console.WriteLine("Ingrese el tamaño del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        Console.WriteLine("Ingrese los elementos del vector A:");
        for (int v = 0; v < n; v++)
        {
            a[v] = int.Parse(Console.ReadLine());
        }

        Array.Sort(a);

        Console.WriteLine("Vector ordenado de forma ascendente:");
        for (int v = 0; v < n; v++)
        {
            Console.WriteLine(a[v]);
        }
    }
}
