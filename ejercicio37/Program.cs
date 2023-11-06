using System;

public class Ejercicio37
{
    public static void GenerarMatrizEnFormaDeX()
    {
        Console.WriteLine("Ingrese el tamaño de la matriz (n):");
        int n = int.Parse(Console.ReadLine());

        char[,] matriz = new char[n, n];

        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s < n; s++)
            {
                matriz[a, s] = (a == s || a == n - s - 1) ? 'X' : ' ';
            }
        }

        Console.WriteLine("Matriz en forma de X:");
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
