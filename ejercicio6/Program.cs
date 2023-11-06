using System;

public class Ejercicio6
{
    public static void SumarDosVectores()
    {
        Console.WriteLine("Ingrese el tamaño de los vectores:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] s = new int[n];
        int[] d = new int[n];

        Console.WriteLine("Ingrese los elementos del vector A:");
        for (int f = 0; f < n; f++)
        {
            a[f] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ingrese los elementos del vector B:");
        for (int f = 0; f < n; f++)
        {
            s[f] = int.Parse(Console.ReadLine());
        }

        for (int f = 0; f < n; f++)
        {
            d[f] = a[f] + s[f];
        }

        Console.WriteLine("Vector resultante de la suma:");
        for (int f = 0; f < n; f++)
        {
            Console.WriteLine(d[f]);
        }
    }
}
