using System;

public class Ejercicio47
{
    public static void SumarMatrices()
    {
        Console.WriteLine("Ingrese el número de filas (n):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número de columnas (m):");
        int m = int.Parse(Console.ReadLine());

        int[,] a = new int[n, m];
        int[,] b = new int[n, m];
        int[,] suma = new int[n, m];

        Console.WriteLine("Llenado de la matriz A:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine($"Ingrese el elemento A[{i},{j}]:");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Llenado de la matriz B:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine($"Ingrese el elemento B[{i},{j}]:");
                b[i, j] = int.Parse(Console.ReadLine());
                suma[i, j] = a[i, j] + b[i, j];
            }
        }

        Console.WriteLine("Matriz resultante de la suma:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(suma[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
