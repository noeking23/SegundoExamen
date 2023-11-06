using System;

public class Ejercicio36
{
    public static void GenerarTableroAjedrez()
    {
        int n = 8;
        int[,] tablero = new int[n, n];

        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s < n; s++)
            {
                tablero[a, s] = (a + s) % 2;
            }
        }

        Console.WriteLine("Tablero de ajedrez:");
        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s < n; s++)
            {
                Console.Write(tablero[a, s] == 1 ? "X " : "O ");
            }
            Console.WriteLine();
        }
    }
}
