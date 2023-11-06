using System;

public class Ejercicio19
{
    public static void SumarVectoresDistintaLongitud()
    {
        Console.WriteLine("Ingrese el tamaño del primer vector:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        Console.WriteLine("Ingrese el tamaño del segundo vector:");
        int m = int.Parse(Console.ReadLine());
        int[] b = new int[m];

        Console.WriteLine("Ingrese los elementos del primer vector:");
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ingrese los elementos del segundo vector:");
        for (int i = 0; i < m; i++)
        {
            b[i] = int.Parse(Console.ReadLine());
        }

        int maxLen = Math.Max(n, m);
        int[] c = new int[maxLen];

        for (int i = 0; i < maxLen; i++)
        {
            int valorA = i < n ? a[i] : 0;
            int valorB = i < m ? b[i] : 0;
            c[i] = valorA + valorB;
        }

        Console.WriteLine("Vector resultante de la suma:");
        for (int i = 0; i < maxLen; i++)
        {
            Console.WriteLine(c[i]);
        }
    }
}
