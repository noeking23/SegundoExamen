using System;

public class Ejercicio24
{
    public static void RotarElementosVector()
    {
        Console.WriteLine("Ingrese la cantidad de elementos del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] original = new int[n];

        Console.WriteLine("Ingrese los elementos del vector:");
        for (int i = 0; i < n; i++)
        {
            original[i] = int.Parse(Console.ReadLine());
        }

        int[] rotado = new int[n];
        rotado[0] = original[n - 1];
        for (int i = 1; i < n; i++)
        {
            rotado[i] = original[i - 1];
        }

        Console.WriteLine("Vector rotado:");
        foreach (var elemento in rotado)
        {
            Console.WriteLine(elemento);
        }
    }
}
