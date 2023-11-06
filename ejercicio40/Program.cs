using System;

public class Ejercicio40
{
    public static void SumarFilasMatriz()
    {
        Console.WriteLine("Ingrese el número de filas (n):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número de columnas (m):");
        int m = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, m];

        for (int a = 0; a < n; a++)
        {
            int sumaFila = 0;
            for (int s = 0; s < m; s++)
            {
                Console.WriteLine($"Ingrese el elemento [{a},{s}]:");
                matriz[a, s] = int.Parse(Console.ReadLine());
                sumaFila += matriz[a, s];
            }
            Console.WriteLine($"La suma de la fila {a} es: {sumaFila}");
        }
    }
}
