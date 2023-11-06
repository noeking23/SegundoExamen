using System;

public class Ejercicio7
{
    public static void SumarVectoresDiagonal()
    {
        Console.WriteLine("Ingrese el tamaño de los vectores:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] b = new int[n];
        int[] c = new int[n];

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
            c[v] = a[v] + b[n - v - 1];
        }

        Console.WriteLine("Vector resultante de la suma diagonal:");
        for (int v = 0; v < n; v++)
        {
            Console.WriteLine(c[v]);
        }
    }
}
