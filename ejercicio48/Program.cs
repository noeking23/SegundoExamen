using System;

public class Ejercicio48
{
    public static void SumaFilasColumnasMatriz()
    {
        Console.WriteLine("Ingrese el número de filas (n):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número de columnas (m):");
        int m = int.Parse(Console.ReadLine());

        int[,] a = new int[n, m];
        int[] sumaFilas = new int[n];
        int[] sumaColumnas = new int[m];

        Console.WriteLine("Llenado de la matriz A:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine($"Ingrese el elemento A[{i},{j}]:");
                a[i, j] = int.Parse(Console.ReadLine());
                sumaFilas[i] += a[i, j];
                sumaColumnas[j] += a[i, j];
            }
        }

        Console.WriteLine("Suma de las filas:");
        foreach (var suma in sumaFilas)
        {
            Console.WriteLine(suma);
        }

        Console.WriteLine("Suma de las columnas:");
        foreach (var suma in sumaColumnas)
        {
            Console.WriteLine(suma);
        }
    }
}
