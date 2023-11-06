using System;

public class Ejercicio46
{
    public static void GenerarMatrizPascal()
    {
        Console.WriteLine("Ingrese el número de filas para la Matriz de Pascal:");
        int n = int.Parse(Console.ReadLine());

        int[,] pascal = new int[n, n];

        for (int a = 0; a < n; a++)
        {
            pascal[a, 0] = 1;

            for (int s = 1; s <= a; s++)
            {
                pascal[a, s] = pascal[a - 1, s - 1] + pascal[a - 1, s];
            }
        }

        Console.WriteLine("Matriz de Pascal:");
        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s <= a; s++)
            {
                Console.Write(pascal[a, s] + " ");
            }
            Console.WriteLine();
        }
    }
}
