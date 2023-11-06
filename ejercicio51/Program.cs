using System;

public class Ejercicio51
{
    public static void BuscarEnMatriz()
    {
        Console.WriteLine("Ingrese el número de filas (n):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número de columnas (m):");
        int m = int.Parse(Console.ReadLine());

        int[,] a = new int[n, m];

        Console.WriteLine("Llenado de la matriz A:");
        for (int k = 0; k < n; k++)
        {
            for (int l = 0; l < m; l++)
            {
                Console.WriteLine($"Ingrese el elemento A[{k},{l}]:");
                a[k, l] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Ingrese el valor a buscar (x):");
        int x = int.Parse(Console.ReadLine());
        bool encontrado = false;

        for (int k = 0; k < n; k++)
        {
            for (int l = 0; l < m; l++)
            {
                if (a[k, l] == x)
                {
                    Console.WriteLine($"El valor {x} se encuentra en la posición [{k},{l}].");
                    encontrado = true;
                }
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Valor no encontrado.");
        }
    }
}
