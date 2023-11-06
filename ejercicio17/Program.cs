using System;

public class Ejercicio17
{
    public static void BusquedaSecuencial()
    {
        Console.WriteLine("Ingrese el tamaño del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        Console.WriteLine("Ingrese los elementos del vector V:");
        for (int i = 0; i < n; i++) 
        {
            v[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ingrese el número a buscar:");
        int numero = int.Parse(Console.ReadLine());
        int posicion = -1;

        for (int i = 0; i < n; i++)
        {
            if (v[i] == numero)
            {
                posicion = i;
                break;
            }
        }

        Console.WriteLine(posicion != -1 ? $"Número encontrado en la posición: {posicion}" : "NO");
    }
}
