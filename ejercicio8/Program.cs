using System;

public class Ejercicio8
{
    public static void IntercalarVectores()
    {
        Console.WriteLine("Ingrese el tamaño de los vectores:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] b = new int[n];
        int[] c = new int[2 * n];

        Console.WriteLine("Ingrese los elementos del vector A:");
        for (int v = 0; v < n; v++)
        {
            a[v] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ingrese los elementos del vector B:");
        for (int v = 0; v < n; v++)
        {
            b[v] = int.Parse(Console.ReadLine());
        }

        for (int v = 0; v < n; v++)
        {
            c[2 * v] = a[v];
            c[2 * v + 1] = b[v];
        }

        Console.WriteLine("Vector intercalado:");
        for (int v = 0; v < 2 * n; v++)
        {
            Console.WriteLine(c[v]);
        }
    }
}
