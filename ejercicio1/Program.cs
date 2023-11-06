using System;

public class Ejercicio1
{
    public static void LlenarYMostrarVector()
    {
        Console.WriteLine("Ingrese el tamaño del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        for (int s = 0; s < n; s++)
        {
            Console.WriteLine($"Ingrese el elemento {s+1} del vector:");
            a[s] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Elementos del vector:");
        for (int s = 0; s < n; s++)
        {
            Console.WriteLine(a[s]);
        }
    }
}
