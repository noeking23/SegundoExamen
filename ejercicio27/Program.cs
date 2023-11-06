using System;

public class Ejercicio26
{
    public static void RotarDerecha()
    {
        Console.WriteLine("Ingrese la cantidad de elementos del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] vector = new int[n];

        Console.WriteLine("Ingrese los elementos del vector:");
        for (int i = 0; i < n; i++)
        {
            vector[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ingrese la cantidad de rotaciones a la derecha:");
        int x = int.Parse(Console.ReadLine());

        for (int r = 0; r < x; r++)
        {
            int ultimo = vector[n - 1];
            for (int i = n - 1; i > 0; i--)
            {
                vector[i] = vector[i - 1];
            }
            vector[0] = ultimo;
        }

        Console.WriteLine("Vector rotado hacia la derecha:");
        foreach (var elemento in vector)
        {
            Console.WriteLine(elemento);
        }
    }
}
