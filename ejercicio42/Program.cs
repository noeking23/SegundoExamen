using System;

public class Ejercicio42
{
    public static void GenerarTranspuestaMatriz()
    {
        Console.WriteLine("Ingrese el tamaño de la matriz cuadrada (n):");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];
        int[,] transpuesta = new int[n, n];

        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s < n; s++)
            {
                Console.WriteLine($"Ingrese el elemento [{a},{s}]:");
                matriz[a, s] = int.Parse(Console.ReadLine());
                transpuesta[s, a] = matriz[a, s];
            }
        }

        Console.WriteLine("Matriz Transpuesta:");
        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s < n; s++)
            {
                Console.Write(transpuesta[a, s] + " ");
            }
            Console.WriteLine();
        }
    }
}
