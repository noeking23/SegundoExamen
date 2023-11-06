using System;

public class Ejercicio13
{
    public static void ClasificarNumeros()
    {
        Console.WriteLine("Ingrese el tamaño del vector:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int ceros = 0, positivos = 0, negativos = 0, sumaPos = 0, sumaNeg = 0;

        Console.WriteLine("Ingrese los elementos del vector A:");
        for (int v = 0; v < n; v++)
        {
            a[v] = int.Parse(Console.ReadLine());
            if (a[v] == 0) ceros++;
            else if (a[v] > 0)
            {
                positivos++;
                sumaPos += a[v];
            }
            else
            {
                negativos++;
                sumaNeg += a[v];
            }
        }

        Console.WriteLine($"Ceros: {ceros}, Positivos: {positivos}, Negativos: {negativos}");
        Console.WriteLine($"Suma de positivos: {sumaPos}, Suma de negativos: {sumaNeg}");
    }
}
