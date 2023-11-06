using System;

public class Ejercicio45
{
    public static void GenerarCruzMatriz()
    {
        Console.WriteLine("Ingrese el tamaño de la matriz (n):");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];

        int numeroParaCruz = (n % 2 == 0) ? 2 : 1;
        int mitad = n / 2;

        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s < n; s++)
            {
                if (n % 2 == 0)
                {
                    if (a == mitad || a == mitad - 1 || s == mitad || s == mitad - 1)
                    {
                        matriz[a, s] = numeroParaCruz;
                    }
                }
                else
                {
                    if (a == mitad || s == mitad)
                    {
                        matriz[a, s] = numeroParaCruz;
                    }
                }
            }
        }

        Console.WriteLine("Matriz con cruz:");
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
