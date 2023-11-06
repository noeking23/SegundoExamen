using System;

public class Ejercicio41
{
    public static void SumarColumnasMatriz()
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
                Console.WriteLine($"Ingrese el elemento [{a},{s}]:");
                matriz[a, s] = int.Parse(Console.ReadLine());
            }
        }

        for (int s = 0; s < m; s++)
        {
            int sumaColumna = 0;
            for (int a = 0; a < n; a++)
            {
                sumaColumna += matriz[a, s];
            }
            Console.WriteLine($"La suma de la columna {s} es: {sumaColumna}");
        }
    }
}
