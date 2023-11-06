using System;

public class Ejercicio23
{
    public static void ConvertirANumeroDeUnDigito()
    {
        Console.WriteLine("Ingrese la cantidad de números:");
        int cantidad = int.Parse(Console.ReadLine());
        int[] numeros = new int[cantidad];

        Console.WriteLine("Ingrese los números:");
        for (int i = 0; i < cantidad; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números convertidos:");
        foreach (var numero in numeros)
        {
            int resultado = ConvertirUnDigito(numero);
            Console.WriteLine(resultado);
        }
    }

    private static int ConvertirUnDigito(int numero)
    {
        while (numero > 9)
        {
            int suma = 0;
            while (numero > 0)
            {
                suma += numero % 10;
                numero /= 10;
            }
            numero = suma;
        }
        return numero;
    }
}
