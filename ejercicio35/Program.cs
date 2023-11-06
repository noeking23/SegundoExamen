using System;

public class Ejercicio35
{
    public static void GenerarMatrizIdentidad()
    {
        Console.WriteLine("Ingrese el tamaño de la matriz identidad (n):");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];

        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s < n; s++)
            {
                matriz[a, s] = (a == s) ? 1 : 0;
            }
        }

        Console.WriteLine("Matriz identidad:");
        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s < n; s++)
            {
                Console.Write(matriz[a, s] + " ");
            }
            Console.WriteLine();
        }
    }
}
