using System;

public class Ejercicio30
{
    public static void GenerarSerie(int n)
    {
        int[] serie = new int[n];
        int numero = 1; 
        int veces = 0;

        for (int i = 0; i < n; i++)
        {
            serie[i] = numero;
            veces++;

            if (veces == numero)
            {
                numero++;
                veces = 0;
            }
        }

        Console.WriteLine("Vector P de la serie:");
        foreach (int valor in serie)
        {
            Console.Write(valor + " ");
        }
    }
}
