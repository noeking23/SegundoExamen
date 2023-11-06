using System;

public class Ejercicio21
{
    public static void PrimerYUltimoDigito()
    {
        Console.WriteLine("Ingrese la cantidad de números:");
        int n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];

        Console.WriteLine("Ingrese los números:");
        for (int i = 0; i < n; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int sumaUltimosDigitos = 0;
        Console.WriteLine("Primer dígito de cada número:");
        foreach (var numero in numeros)
        {
            string numStr = numero.ToString();
            Console.WriteLine(numStr[0]);

            sumaUltimosDigitos += int.Parse(numStr[numStr.Length - 1].ToString());
        }

        Console.WriteLine($"Suma de últimos dígitos: {sumaUltimosDigitos}");
    }
}
