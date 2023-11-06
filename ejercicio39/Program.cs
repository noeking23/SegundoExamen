using System;

public class Ejercicio39
{
    public static void SumarValoresMatriz()
    {
        Console.WriteLine("Ingrese el número de filas (n):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número de columnas (m):");
        int m = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, m];
        int sumaTotal = 0;

        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s < m; s++)
            {
                Console.WriteLine($"Ingrese el elemento [{a},{s}]:");
                matriz[a, s] = int.Parse(Console.ReadLine());
                sumaTotal += matriz[a, s];
            }
        }

        Console.WriteLine($"La suma total de los elementos de la matriz es: {sumaTotal}");
    }
}
