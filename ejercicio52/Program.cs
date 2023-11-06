using System;
using System.Linq;

public class Ejercicio52
{
    public static void GenerarVectoresOrdenados()
    {
        Console.WriteLine("Ingrese el número de filas (n):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número de columnas (m):");
        int m = int.Parse(Console.ReadLine());

        int[,] a = new int[n, m];

        Console.WriteLine("Llenado de la matriz A:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine($"Ingrese el elemento A[{i},{j}]:");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < n; i++)
        {
            int[] vector = new int[m];
            for (int j = 0; j < m; j++)
            {
                vector[j] = a[i, j];
            }

            if (i % 2 == 0)
            {
                Array.Sort(vector);
            }
            else
            {
                Array.Sort(vector, (a, b) => b.CompareTo(a));
            }

            Console.WriteLine($"Vector ordenado de la fila {(i + 1)}:");
            Console.WriteLine(string.Join(" ", vector));
        }
    }
}
