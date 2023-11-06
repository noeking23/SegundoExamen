using System;

public class Ejercicio44
{
    public static void GenerarMatrizSerpiente()
    {
        Console.WriteLine("Ingrese el tamaño de la matriz (n):");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];
        int valor = 1;

        for (int a = 0; a < n; a++)
        {
            if (a % 2 == 0)
            {
                for (int s = 0; s < n; s++)
                {
                    matriz[a, s] = valor++;
                }
            }
            else
            {
                for (int s = n - 1; s >= 0; s--)
                {
                    matriz[a, s] = valor++;
                }
            }
        }

        Console.WriteLine("Matriz en forma de serpiente:");
        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s < n; s++)
            {
                Console.Write(matriz[a, s].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
    }
}
