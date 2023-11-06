using System;

public class EvaluacionDeNotas
{
    public static void AnalizarNotas()
    {
        Console.WriteLine("Ingrese el número de alumnos (N):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número de materias (M):");
        int m = int.Parse(Console.ReadLine());

        double[,] notas = new double[n, m];

        for (int a = 0; a < n; a++)
        {
            for (int s = 0; s < m; s++)
            {
                Console.WriteLine($"Ingrese la nota del alumno {a + 1} en la materia {s + 1} (-1 si no se presentó):");
                notas[a, s] = double.Parse(Console.ReadLine());
            }
        }

        for (int s = 0; s < m; s++)
        {
            int presentados = 0;
            int noPresentados = 0;
            int aprobados = 0;
            int notables = 0;
            int sobresalientes = 0;
            double sumaNotas = 0;

            for (int a = 0; a < n; a++)
            {
                if (notas[a, s] != -1)
                {
                    presentados++;
                    sumaNotas += notas[a, s];

                    if (notas[a, s] >= 50)
                    {
                        aprobados++;
                    }
                    if (notas[a, s] >= 80 && notas[a, s] < 90)
                    {
                        notables++;
                    }
                    if (notas[a, s] >= 90)
                    {
                        sobresalientes++;
                    }
                }
                else
                {
                    noPresentados++;
                }
            }

            double notaMedia = presentados > 0 ? sumaNotas / presentados : 0;

            Console.WriteLine($"Materia {s + 1}:");
            Console.WriteLine($"Número de alumnos presentados: {presentados}");
            Console.WriteLine($"Nota media: {notaMedia:F2}");
            Console.WriteLine($"Número que no se presentó al examen: {noPresentados}");
            Console.WriteLine($"Número de aprobados: {aprobados}");
            Console.WriteLine($"Número de notables: {notables}");
            Console.WriteLine($"Número de sobresalientes: {sobresalientes}");
        }
    }
}
