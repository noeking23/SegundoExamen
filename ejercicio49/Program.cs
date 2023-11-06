using System;

public class Ejercicio49
{
    public static void SumarFilasColumnas()
    {
        Console.WriteLine("Ingrese el número de filas (n):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número de columnas (m):");
        int m = int.Parse(Console.ReadLine());

        int[,] a = new int[n, m];
        int[,] b = new int[n, m];
        int[] suma = new int[Math.Max(n, m)];

        Console.WriteLine("Llenado de la matriz A:");
        for (int d = 0; d < n; d++)
        {
            for (int f = 0; f < m; f++)
            {
                Console.WriteLine($"Ingrese el elemento A[{d},{f}]:");
                a[d, f] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Llenado de la matriz B:");
        for (int d = 0; d < n; d++)
        {
            for (int f = 0; f < m; f++)
            {
                Console.WriteLine($"Ingrese el elemento B[{d},{f}]:");
                b[d, f] = int.Parse(Console.ReadLine());
            }
        }

        for (int d = 0; d < n; d++)
        {
            for (int f = 0; f < m; f++)
            {
                suma[d] += a[d, f];
                suma[f] += b[d, f];
            }
        }

        Console.WriteLine("Resultado de la suma:");
        foreach (var s in suma)
        {
            Console.WriteLine(s);
        }
    }
}
