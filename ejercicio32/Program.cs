using System;

public class Ejercicio32
{
    public static void LlenarMatrizConUnos()
    {
        Console.WriteLine("Ingrese el número de filas (n):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número de columnas (m):");
        int m = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, m];

        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s < m; s++)
            {
                matriz[a, s] = 1;
            }
        }

        Console.WriteLine("Matriz de unos:");
        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s < m; s++)
            {
                Console.Write(matriz[a, s] + " ");
            }
            Console.WriteLine();
        }
    }
}
