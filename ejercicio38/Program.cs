using System;

public class Ejercicio38
{
    public static void GenerarMatrizCaracol()
    {
        Console.WriteLine("Ingrese el tamaño de la matriz (n):");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];
        int valor = 1;
        int a, s;
        int limite = n;

        for (int m = 0; m < (n + 1) / 2; m++)
        {
            for (s = m; s < limite; s++) matriz[m, s] = valor++;
            for (a = m + 1; a < limite; a++) matriz[a, limite - 1] = valor++;
            for (s = limite - 2; s >= m; s--) matriz[limite - 1, s] = valor++;
            for (a = limite - 2; a > m; a--) matriz[a, m] = valor++;
            limite--;
        }

        Console.WriteLine("Matriz caracol:");
        for (a = 0; a < n; a++)
        {
            for (s = 0; s < n; s++)
            {
                Console.Write(matriz[a, s].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
    }
}
