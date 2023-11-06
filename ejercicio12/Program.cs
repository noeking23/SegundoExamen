using System;

public class Ejercicio12
{
    public static void ElevarCuadrados()
    {
        Console.WriteLine("Ingrese el tamaño del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] b = new int[n];

        Console.WriteLine("Ingrese los elementos del vector A:");
        for (int v = 0; v < n; v++)
        {
            a[v] = int.Parse(Console.ReadLine());
            b[v] = a[v] * a[v];
        }

        Console.WriteLine("Vector A original:");
        foreach (int valor in a)
        {
            Console.WriteLine(valor);
        }

        Console.WriteLine("Vector B con los cuadrados:");
        foreach (int valor in b)
        {
            Console.WriteLine(valor);
        }
    }
}
