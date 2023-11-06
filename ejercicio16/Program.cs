using System;

public class Ejercicio16
{
    public static void VerificarOrden()
    {
        Console.WriteLine("Ingrese el tamaño del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        Console.WriteLine("Ingrese los elementos del vector A:");
        for (int v = 0; v < n; v++)
        {
            a[v] = int.Parse(Console.ReadLine());
        }

        bool estaOrdenado = true;
        for (int v = 0; v < n - 1; v++)
        {
            if (a[v] > a[v + 1])
            {
                estaOrdenado = false;
                break;
            }
        }

        Console.WriteLine(estaOrdenado ? "SI" : "NO");
    }
}
