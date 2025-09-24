using System;

class Programa
{
    static void Main()
    {
        double nota = 9.2;

        if (nota >= 6.0)
        {
            Console.WriteLine("Aprobado.");

            if (nota >= 9.0)
            {
                Console.WriteLine("¡Excelente calificación!");
            }
        }
        else
        {
            Console.WriteLine("Reprobado.");
        }
    }
}
