using System;

public class Ejercicio43
{
    public static void GenerarMatrizAscDesc()
    {
        Console.WriteLine("Ingrese el tamaño de la matriz (n):");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];

        for (int a = 0; a < n; a++)
        {
            if (a % 2 == 0)
            {
                for (int s = 0; s < n; s++)
                {
                    matriz[a, s] = s + 1;
                }
            }
            else
            {
                for (int s = 0; s < n; s++)
                {
                    matriz[a, s] = n - s;
                }
            }
        }

        Console.WriteLine("Matriz ascendente/descendente:");
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
