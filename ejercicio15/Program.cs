using System;

public class Ejercicio15
{
    public static void CompararVectores()
    {
        Console.WriteLine("Ingrese el tamaño de los vectores:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] b = new int[n];

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

        bool sonIguales = true;
        for (int v = 0; v < n; v++)
        {
            if (a[v] != b[v])
            {
                sonIguales = false;
                break;
            }
        }

        Console.WriteLine(sonIguales ? "IGUALES" : "DIFERENTES");
    }
}
