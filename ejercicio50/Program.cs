using System;

public class Ejercicio50
{
    public static void ContarNumerosMatriz()
    {
        Console.WriteLine("Ingrese el número de filas (n):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número de columnas (m):");
        int m = int.Parse(Console.ReadLine());

        int[,] a = new int[n, m];
        int primos = 0, pares = 0, impares = 0;

        Console.WriteLine("Llenado de la matriz A:");
        for (int h = 0; h < n; h++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine($"Ingrese el elemento A[{h},{j}]:");
                a[h, j] = int.Parse(Console.ReadLine());

                // Verificar si es primo
                bool esPrimo = true;
                if (a[h, j] < 2) esPrimo = false;
                for (int k = 2; k * k <= a[h, j]; k++)
                {
                    if (a[h, j] % k == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo) primos++;

                // Verificar si es par o impar
                if (a[h, j] % 2 == 0) pares++;
                else impares++;
            }
        }

        Console.WriteLine($"Cantidad de primos: {primos}");
        Console.WriteLine($"Cantidad de pares: {pares}");
        Console.WriteLine($"Cantidad de impares: {impares}");
    }
}
