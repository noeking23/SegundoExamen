using System;

public class Ejercicio34
{
    public static void LlenarMatrizConNaturalesPorColumnas()
    {
        Console.WriteLine("Ingrese el número de filas (n):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número de columnas (m):");
        int m = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, m];
        int d = 1; 

        for (int s = 0; s < m; s++)
        {
            for (int a = 0; a < n; a++)
            {
                matriz[a, s] = d++;
            }
        }

        Console.WriteLine("Matriz con números naturales por columnas:");
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
